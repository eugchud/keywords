using SolarixLemmatizatorEngineNET;
using System;
using System.Collections.Generic;
using System.IO;

public class Processor
{
    IntPtr hEngine;
    public string text;
    public string blacklistText;
    public List<string> wordsList;
    public List<int> wordsCount;
    public List<string> blacklist;
    public bool lemmatize = true;
    public bool deletenumbers = true;
    public bool blacklistEnabled = true;
    public int wordsTotal;
    public int wordsUnique;

    public delegate void ProgressUpdate(int value);
    public event ProgressUpdate OnProgressUpdate;


    public Processor()
	{
        // attach database
        hEngine = LemmatizatorEngine.sol_LoadLemmatizatorW("lemmatizer.db", 0);


    }

    bool isGood(char c)
    {
        return (c >= 'А' && c <= 'Я') || (c >= 'а' && c <= 'я') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || (c >= '0' && c <= '9');
    }

    public void process()
    {

        //tokenize

        bool prevgood = false;
        bool currgood = false;
        string wordinprogress = "";
        for (int i = 0; i < text.Length; i++)
        {
            char currch = text[i];

            if (!isGood(currch))
            {
                currgood = false;
            }
            else
            {
                currgood = true;
            }
            if (!prevgood && !currgood)
            {
                //do nothing
            }
            if (!prevgood && currgood)
            {
                wordinprogress = wordinprogress + text[i];
            }
            if (prevgood && currgood)
            {
                wordinprogress = wordinprogress + text[i];
            }
            if (prevgood && !currgood)
            {
                wordsList.Add(wordinprogress);
                wordinprogress = "";
            }
            prevgood = currgood;
        }

        bool badchar = false;

        for (int i = 0; i < wordinprogress.Length; i++)
        {
            if (!isGood(wordinprogress[i]))
            {
                badchar = true;
            }
        }

        if (wordinprogress == "")
        {
            badchar = true;
        }

        if (!badchar)
        {
            wordsList.Add(wordinprogress);
        }


        if (OnProgressUpdate != null)
        {
            OnProgressUpdate(17);
        }


        wordsTotal = wordsList.Count;

        //lemmatize

        if (lemmatize)
        {
            for (int i = 0; i < wordsList.Count; i++)
            {

                System.Text.StringBuilder lemma = new System.Text.StringBuilder();
                lemma.EnsureCapacity(32);

                LemmatizatorEngine.sol_GetLemmaW(hEngine, wordsList[i], lemma, 32);
                String slemma = lemma.ToString();
                wordsList[i] = slemma;

                if (OnProgressUpdate != null)
                {
                    OnProgressUpdate(17 + i * 83 / wordsList.Count);
                }
            }
        }

        //get to lowercase

        for (int i = 0; i < wordsList.Count; i++)
        {
            wordsList[i] = wordsList[i].ToLower();
        }

        //count words

        for (int i = 0; i < wordsList.Count; i++)
        {
            int count = 1;
            int j = i + 1;
            while (j < wordsList.Count)
            {
                if (wordsList[i] == wordsList[j])
                {
                    count++;
                    wordsList.RemoveAt(j);
                    j--;
                }
                j++;
            }
            wordsCount.Add(count);

        }

        //delete numbers

        if (deletenumbers)
        {
            int i1 = 0;
            while (i1 < wordsList.Count)
            {
                int n;
                bool isNumeric = int.TryParse(wordsList[i1], out n);
                if (isNumeric)
                {
                    wordsList.RemoveAt(i1);
                    wordsCount.RemoveAt(i1);
                    i1--;
                }
                i1++;
            }
        }

        //delete words from blacklist

        if (blacklistEnabled)

        {

            int i2 = 0;
            while (i2 < wordsList.Count)
            {
                for (int i3 = 0; i3 < blacklist.Count; i3++)
                {
                    if (wordsList[i2] == blacklist[i3])
                    {
                        wordsList.RemoveAt(i2);
                        wordsCount.RemoveAt(i2);
                        i2--;
                        goto m1;

                    }
                }
            m1: i2++;
            }
        }

        //form the final list

        wordsUnique = wordsList.Count;

    }
}
