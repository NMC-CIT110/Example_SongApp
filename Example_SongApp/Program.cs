﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// **************************************************
//
// Title: Song App
// Description: Example code of using the beep method to play a simple song
// Application Type: Console
// Author: Velis, John
// Dated Created: 4/25/2020
// Last Modified: 
//
// **************************************************
namespace Example_SongApp
{

    public enum NoteName
    {
        C,
        CSharp,
        D
    }

    public enum NoteLength
    {
        WHOLE = 1000,
        HALF = 500,
        QUARTER = 250,
        EIGHTH = 125
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<NoteName, int> octave4 = new Dictionary<NoteName, int>();
            InitializeOctave4(octave4);

            List<SongNote> Song1 = new List<SongNote>();
            InitializeSong1(Song1);

            int tempoMultiplier = 4;

            PlaySong(Song1, octave4, tempoMultiplier);

            Console.ReadKey();
        }

        /// <summary>
        /// play a song with a given octave and tempo
        /// </summary>
        /// <param name="song">list of notes for a song</param>
        /// <param name="octave">dictionary of notes and frequencies</param>
        /// <param name="tempoMultiplayer">song tempo as a multiplier</param>
        static void PlaySong(List<SongNote> song, Dictionary<NoteName, int> octave, int tempoMulitplier)
        {
            int noteFrequency;
            int noteLength;

            foreach (SongNote songNote in song)
            {
                noteFrequency = octave[songNote.Name];
                noteLength = (int)songNote.Length * tempoMulitplier;

                Console.Beep(noteFrequency, noteLength);
            }
        }

        /// <summary>
        /// initialize octave 4 dictionary with note frequencies
        /// </summary>
        /// <param name="octave4">dictionary of frequencies for octave 4</param>
        static void InitializeOctave4(Dictionary<NoteName, int> octave4)
        {
            octave4.Add(NoteName.C, 261);
            octave4.Add(NoteName.CSharp, 277);
            octave4.Add(NoteName.D, 294);
        }

        /// <summary>
        /// initialize a song with the notes and their lengths
        /// </summary>
        /// <param name="songNotes">list of song notes</param>
        static void InitializeSong1(List<SongNote> songNotes)
        {
            songNotes.Add(new SongNote(NoteName.C, NoteLength.QUARTER));
            songNotes.Add(new SongNote(NoteName.CSharp, NoteLength.QUARTER));
            songNotes.Add(new SongNote(NoteName.D, NoteLength.WHOLE));
            songNotes.Add(new SongNote(NoteName.D, NoteLength.EIGHTH));
            songNotes.Add(new SongNote(NoteName.CSharp, NoteLength.EIGHTH));
            songNotes.Add(new SongNote(NoteName.C, NoteLength.EIGHTH));
            songNotes.Add(new SongNote(NoteName.C, NoteLength.EIGHTH));
            songNotes.Add(new SongNote(NoteName.CSharp, NoteLength.EIGHTH));
            songNotes.Add(new SongNote(NoteName.D, NoteLength.EIGHTH));
            songNotes.Add(new SongNote(NoteName.D, NoteLength.WHOLE));
        }
    }
}
