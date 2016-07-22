using System;

namespace TimerApp.Model
{
    public enum ContinuationMode
    {
        Automatic,
        Manual
    }

    public class Step
    {
        public string Title { get; set; }
        public string Instruction { get; set; }
        public TimeSpan Time { get; set; }
        public ContinuationMode ContinuationMode { get; set; }

        public bool IsTimed { get { return Time.TotalMilliseconds > 0; } }
        public bool IsTitleOnly { get { return string.IsNullOrWhiteSpace(Instruction); } }
    }
}