using System;

namespace Enumerationen
{
    [Flags]
    public enum Wochentage : byte
    {
        Montag = 1<<0,
        Dienstag = 1<<1,
        Mittwoch = 1<<2,
        Donnerstag = 1<<3,
        Freitag = 1<<4,
        Samstag = 1<<5,
        Sonntag = 1<<6
    }
}
