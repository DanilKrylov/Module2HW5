using System;

namespace HW
{
    class LoggInfo
    {
        DateTime _dateTime;

        string _loggTipe;

        string _message;

        public LoggInfo(DateTime dateTime, string loggTipe, string message)
        {
            _dateTime = dateTime;

            _loggTipe = loggTipe;

            _message = message;
        }

        public new string ToString()
        {
            return _dateTime.ToString() + " " + _loggTipe + " " + _message;
        }
    }
}