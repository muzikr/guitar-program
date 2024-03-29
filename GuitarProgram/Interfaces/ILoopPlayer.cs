﻿namespace GuitarProgram
{
    internal interface ILoopPlayer
    {
        /// <summary>
        /// Sets/returns given loop to current loop
        /// </summary>
        public List<Chord> Loop { set; get; }

        /// <summary>
        /// Returns number of chords in current loop
        /// </summary>
        public int NumberOfChords { get; }

        /// <summary>
        /// Converts given text to loop
        /// </summary>
        /// <param name="input">Input text in defined format</param>
        /// <returns>Negative number if successful, otherwise line number where error is</returns>
        public int LoadLoop(string[] input);

        /// <summary>
        /// Increases pointer and returns next chord
        /// </summary>
        /// <returns>Next chord in loop</returns>
        public Chord NextChord();

        /// <summary>
        /// Resets pointer of the loop to the beggining
        /// </summary>
        public void Reset();
    }
}
