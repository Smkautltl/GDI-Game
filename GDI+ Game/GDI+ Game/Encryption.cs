using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Game
{
    class Encryption
    {
        public string Encrypt(string character)
        {
            Random r = new Random();

            switch (character)
            {
                case "0":
                    switch (r.Next(1, 3))
                    {
                        case 1:
                            character = "á";
                            break;

                        case 2:
                            character = " ";
                            break;
                    }
                    break;

                case "1":
                    switch (r.Next(1, 3))
                    {
                        case 1:
                            character = "→";
                            break;

                        case 2:
                            character = "ê";
                            break;
                    }
                    break;

                case "2":
                    switch (r.Next(1, 3))
                    {
                        case 1:
                            character = "↓";
                            break;

                        case 2:
                            character = "■";
                            break;
                    }
                    break;

                case "3":
                    switch (r.Next(1, 3))
                    {
                        case 1:
                            character = "♥";
                            break;

                        case 2:
                            character = "Å";
                            break;
                    }
                    break;

                case "4":
                    switch (r.Next(1, 3))
                    {
                        case 1:
                            character = "◙";
                            break;

                        case 2:
                            character = "ò";
                            break;
                    }
                    break;

                case "5":
                    switch (r.Next(1, 3))
                    {
                        case 1:
                            character = "☼";
                            break;

                        case 2:
                            character = "é";
                            break;
                    }
                    break;

                case "6":
                    switch (r.Next(1, 3))
                    {
                        case 1:
                            character = "♦";
                            break;

                        case 2:
                            character = "ü";
                            break;
                    }
                    break;

                case "7":
                    switch (r.Next(1, 3))
                    {
                        case 1:
                            character = "↔";
                            break;

                        case 2:
                            character = "×";
                            break;
                    }
                    break;

                case "8":
                    switch (r.Next(1, 3))
                    {
                        case 1:
                            character = "t";
                            break;

                        case 2:
                            character = "µ";
                            break;
                    }
                    break;
                case "9":
                    switch (r.Next(1, 3))
                    {
                        case 1:
                            character = "╣";
                            break;

                        case 2:
                            character = "ï";
                            break;
                    }
                    break;

                case ",":
                    switch (r.Next(1,4))
                    {
                        case 1:
                            character = "i";
                            break;
                        case 2:
                            character = "u";
                            break;
                        case 3:
                            character = "P";
                            break;
                    }
                    break;

                case " ":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "E";
                            break;

                        case 2:
                            character = "O";
                            break;

                        case 3:
                            character = "▓";
                            break;
                    }
                    break;

                case "a":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "J";
                            break;

                        case 2:
                            character = "Q";
                            break;

                        case 3:
                            character = "☺";
                            break;
                    }
                    break;

                case "b":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = ".";
                            break;

                        case 2:
                            character = "k";
                            break;

                        case 3:
                            character = "♪";
                            break;
                    }
                    break;

                case "c":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "b";
                            break;

                        case 2:
                            character = "d";
                            break;

                        case 3:
                            character = "¹";
                            break;
                    }
                    break;

                case "d":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "Z";
                            break;

                        case 2:
                            character = "&";
                            break;

                        case 3:
                            character = "Æ";
                            break;
                    }
                    break;

                case "e":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "a";
                            break;

                        case 2:
                            character = "9";
                            break;

                        case 3:
                            character = "►";
                            break;
                    }
                    break;

                case "f":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "(";
                            break;

                        case 2:
                            character = "_";
                            break;

                        case 3:
                            character = "Ü";
                            break;
                    }
                    break;

                case "g":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "M";
                            break;

                        case 2:
                            character = "G";
                            break;

                        case 3:
                            character = "±";
                            break;
                    }
                    break;

                case "h":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "m";
                            break;

                        case 2:
                            character = "C";
                            break;

                        case 3:
                            character = "↨";
                            break;
                    }
                    break;

                case "i":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "-";
                            break;

                        case 2:
                            character = "2";
                            break;

                        case 3:
                            character = "↕";
                            break;
                    }
                    break;

                case "j":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "x";
                            break;

                        case 2:
                            character = "q";
                            break;

                        case 3:
                            character = "▼";
                            break;
                    }
                    break;

                case "k":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "w";
                            break;

                        case 2:
                            character = "j";
                            break;

                        case 3:
                            character = "█";
                            break;
                    }
                    break;

                case "l":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "r";
                            break;

                        case 2:
                            character = "g";
                            break;

                        case 3:
                            character = "Š";
                            break;
                    }
                    break;

                case "m":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "l";
                            break;

                        case 2:
                            character = "@";
                            break;

                        case 3:
                            character = "¼";
                            break;
                    }
                    break;

                case "n":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "Ú";
                            break;

                        case 2:
                            character = "'";
                            break;

                        case 3:
                            character = "ì";
                            break;
                    }
                    break;

                case "o":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "c";
                            break;

                        case 2:
                            character = "n";
                            break;

                        case 3:
                            character = "ó";
                            break;
                    }
                    break;

                case "p":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "D";
                            break;

                        case 2:
                            character = ":";
                            break;

                        case 3:
                            character = "½";
                            break;
                    }
                    break;

                case "q":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "=";
                            break;

                        case 2:
                            character = "/";
                            break;

                        case 3:
                            character = "¬";
                            break;
                    }
                    break;

                case "r":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "K";
                            break;

                        case 2:
                            character = "!";
                            break;

                        case 3:
                            character = "┤";
                            break;
                    }
                    break;

                case "s":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = ";";
                            break;

                        case 2:
                            character = "8";
                            break;

                        case 3:
                            character = "Ò";
                            break;
                    }
                    break;

                case "t":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "S";
                            break;

                        case 2:
                            character = "1";
                            break;

                        case 3:
                            character = "É";
                            break;
                    }
                    break;

                case "u":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "L";
                            break;

                        case 2:
                            character = "%";
                            break;

                        case 3:
                            character = "╝";
                            break;
                    }
                    break;

                case "v":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "h";
                            break;

                        case 2:
                            character = "6";
                            break;

                        case 3:
                            character = "^";
                            break;
                    }
                    break;

                case "w":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "+";
                            break;

                        case 2:
                            character = "v";
                            break;

                        case 3:
                            character = "å";
                            break;
                    }
                    break;

                case "x":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "p";
                            break;

                        case 2:
                            character = "4";
                            break;

                        case 3:
                            character = "░";
                            break;
                    }
                    break;

                case "y":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "o";
                            break;

                        case 2:
                            character = "7";
                            break;

                        case 3:
                            character = "Ô";
                            break;
                    }
                    break;

                case "z":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "]";
                            break;

                        case 2:
                            character = "Y";
                            break;

                        case 3:
                            character = "Þ";
                            break;
                    }
                    break;

                case "A":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "f";
                            break;

                        case 2:
                            character = "0";
                            break;

                        case 3:
                            character = "ù";
                            break;
                    }
                    break;

                case "B":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "N";
                            break;

                        case 2:
                            character = "↑";
                            break;

                        case 3:
                            character = "ƒ";
                            break;
                    }
                    break;

                case "C":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "H";
                            break;

                        case 2:
                            character = "ë";
                            break;

                        case 3:
                            character = "è";
                            break;
                    }
                    break;

                case "D":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "F";
                            break;

                        case 2:
                            character = "3";
                            break;

                        case 3:
                            character = "▬";
                            break;
                    }
                    break;

                case "E":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "{";
                            break;

                        case 2:
                            character = "♠";
                            break;

                        case 3:
                            character = "û";
                            break;
                    }
                    break;

                case "F":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "~";
                            break;

                        case 2:
                            character = "¶";
                            break;

                        case 3:
                            character = "€";
                            break;
                    }
                    break;

                case "G":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "<";
                            break;

                        case 2:
                            character = "◄";
                            break;

                        case 3:
                            character = "ö";
                            break;
                    }
                    break;

                case "H":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "V";
                            break;

                        case 2:
                            character = "â";
                            break;

                        case 3:
                            character = "Ñ";
                            break;
                    }
                    break;

                case "I":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "5";
                            break;

                        case 2:
                            character = "♣";
                            break;

                        case 3:
                            character = "♂";
                            break;
                    }
                    break;

                case "J":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "W";
                            break;

                        case 2:
                            character = "Ì";
                            break;

                        case 3:
                            character = "à";
                            break;
                    }
                    break;

                case "K":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "[";
                            break;

                        case 2:
                            character = "○";
                            break;

                        case 3:
                            character = "Ç";
                            break;
                    }
                    break;

                case "L":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "Ä";
                            break;

                        case 2:
                            character = "}";
                            break;

                        case 3:
                            character = "‼";
                            break;
                    }
                    break;

                case "M":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "|";
                            break;

                        case 2:
                            character = "`";
                            break;

                        case 3:
                            character = "♫";
                            break;
                    }
                    break;

                case "N":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "⌂";
                            break;

                        case 2:
                            character = "Ø";
                            break;

                        case 3:
                            character = "ª";
                            break;
                    }
                    break;

                case "O":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "A";
                            break;

                        case 2:
                            character = "☻";
                            break;

                        case 3:
                            character = "î";
                            break;
                    }
                    break;

                case "P":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "T";
                            break;

                        case 2:
                            character = "←";
                            break;

                        case 3:
                            character = "»";
                            break;
                    }
                    break;

                case "Q":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "$";
                            break;

                        case 2:
                            character = "X";
                            break;

                        case 3:
                            character = "«";
                            break;
                    }
                    break;

                case "R":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "?";
                            break;

                        case 2:
                            character = "y";
                            break;

                        case 3:
                            character = "♀";
                            break;
                    }
                    break;

                case "S":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "I";
                            break;

                        case 2:
                            character = "║";
                            break;

                        case 3:
                            character = "ÿ";
                            break;
                    }
                    break;

                case "T":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = @"\";
                            break;

                        case 2:
                            character = "∟";
                            break;

                        case 3:
                            character = "í";
                            break;
                    }
                    break;

                case "U":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "B";
                            break;

                        case 2:
                            character = "¦";
                            break;

                        case 3:
                            character = "•";
                            break;
                    }
                    break;

                case "V":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "R";
                            break;

                        case 2:
                            character = "▲";
                            break;

                        case 3:
                            character = "æ";
                            break;
                    }
                    break;

                case "W":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "#";
                            break;

                        case 2:
                            character = "e";
                            break;

                        case 3:
                            character = "º";
                            break;
                    }
                    break;

                case "X":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "§";
                            break;

                        case 2:
                            character = "◘";
                            break;

                        case 3:
                            character = "Ö";
                            break;
                    }
                    break;

                case "Y":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "s";
                            break;

                        case 2:
                            character = "z";
                            break;

                        case 3:
                            character = "ø";
                            break;
                    }
                    break;

                case "Z":
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            character = "þ";
                            break;

                        case 2:
                            character = "ô";
                            break;

                        case 3:
                            character = "©";
                            break;
                    }
                    break;

            }

            return character;
        }

        public string Decrypt(string character)
        {
            switch (character)
            {
                case "á":
                    character = "0";
                    break;
                case " ":
                    character = "0";
                    break;
                case "→":
                    character = "1";
                    break;
                case "ê":
                    character = "1";
                    break;
                case "↓":
                    character = "2";
                    break;
                case "■":
                    character = "2";
                    break;
                case "♥":
                    character = "3";
                    break;
                case "Å":
                    character = "3";
                    break;
                case "◙":
                    character = "4";
                    break;
                case "ò":
                    character = "4";
                    break;
                case "☼":
                    character = "5";
                    break;
                case "é":
                    character = "5";
                    break;
                case "♦":
                    character = "6";
                    break;
                case "ü":
                    character = "6";
                    break;
                case "↔":
                    character = "7";
                    break;
                case "×":
                    character = "7";
                    break;
                case "t":
                    character = "8";
                    break;
                case "µ":
                    character = "8";
                    break;
                case "╣":
                    character = "9";
                    break;
                case "ï":
                    character = "9";
                    break;

                case "i":
                    character = ",";
                    break;
                case "u":
                    character = ",";
                    break;
                case "P":
                    character = ",";
                    break;

                case "E":
                    character = " ";
                    break;
                case "O":
                    character = " ";
                    break;
                case "▓":
                    character = " ";
                    break;
                case "J":
                    character = "a";
                    break;
                case "Q":
                    character = "a";
                    break;
                case "☺":
                    character = "a";
                    break;

                case ".":
                    character = "b";
                    break;
                case "k":
                    character = "b";
                    break;
                case "♪":
                    character = "b";
                    break;

                case "b":
                    character = "c";
                    break;
                case "d":
                    character = "c";
                    break;
                case "¹":
                    character = "c";
                    break;

                case "Z":
                    character = "d";
                    break;
                case "&":
                    character = "d";
                    break;
                case "Æ":
                    character = "d";
                    break;

                case "a":
                    character = "e";
                    break;
                case "9":
                    character = "e";
                    break;
                case "►":
                    character = "e";
                    break;

                case "(":
                    character = "f";
                    break;
                case "_":
                    character = "f";
                    break;
                case "Ü":
                    character = "f";
                    break;

                case "M":
                    character = "g";
                    break;
                case "G":
                    character = "g";
                    break;
                case "±":
                    character = "g";
                    break;

                case "m":
                    character = "h";
                    break;
                case "C":
                    character = "h";
                    break;
                case "↨":
                    character = "h";
                    break;

                case "-":
                    character = "i";
                    break;
                case "2":
                    character = "i";
                    break;
                case "↕":
                    character = "i";
                    break;

                case "x":
                    character = "j";
                    break;
                case "q":
                    character = "j";
                    break;
                case "▼":
                    character = "j";
                    break;

                case "w":
                    character = "k";
                    break;
                case "j":
                    character = "k";
                    break;
                case "█":
                    character = "k";
                    break;

                case "r":
                    character = "l";
                    break;
                case "g":
                    character = "l";
                    break;
                case "Š":
                    character = "l";
                    break;

                case "l":
                    character = "m";
                    break;
                case "@":
                    character = "m";
                    break;
                case "¼":
                    character = "m";
                    break;

                case "Ú":
                    character = "n";
                    break;
                case "'":
                    character = "n";
                    break;
                case "ì":
                    character = "n";
                    break;

                case "c":
                    character = "o";
                    break;
                case "n":
                    character = "o";
                    break;
                case "ó":
                    character = "o";
                    break;

                case "D":
                    character = "p";
                    break;
                case ":":
                    character = "p";
                    break;
                case "½":
                    character = "p";
                    break;

                case "=":
                    character = "q";
                    break;
                case "/":
                    character = "q";
                    break;
                case "¬":
                    character = "q";
                    break;

                case "K":
                    character = "r";
                    break;
                case "!":
                    character = "r";
                    break;
                case "┤":
                    character = "r";
                    break;

                case ";":
                    character = "s";
                    break;
                case "8":
                    character = "s";
                    break;
                case "Ò":
                    character = "s";
                    break;

                case "S":
                    character = "t";
                    break;
                case "1":
                    character = "t";
                    break;
                case "É":
                    character = "t";
                    break;

                case "L":
                    character = "u";
                    break;
                case "%":
                    character = "u";
                    break;
                case "╝":
                    character = "u";
                    break;

                case "h":
                    character = "v";
                    break;
                case "6":
                    character = "v";
                    break;
                case "^":
                    character = "v";
                    break;

                case "+":
                    character = "w";
                    break;
                case "v":
                    character = "w";
                    break;
                case "å":
                    character = "w";
                    break;

                case "p":
                    character = "x";
                    break;
                case "4":
                    character = "x";
                    break;
                case "░":
                    character = "x";
                    break;

                case "o":
                    character = "y";
                    break;
                case "7":
                    character = "y";
                    break;
                case "Ô":
                    character = "y";
                    break;

                case "]":
                    character = "z";
                    break;
                case "Y":
                    character = "z";
                    break;
                case "Þ":
                    character = "z";
                    break;

                case "f":
                    character = "A";
                    break;
                case "0":
                    character = "A";
                    break;
                case "ù":
                    character = "A";
                    break;

                case "N":
                    character = "B";
                    break;
                case "↑":
                    character = "B";
                    break;
                case "ƒ":
                    character = "B";
                    break;

                case "H":
                    character = "C";
                    break;
                case "ë":
                    character = "C";
                    break;
                case "è":
                    character = "C";
                    break;

                case "F":
                    character = "D";
                    break;
                case "3":
                    character = "D";
                    break;
                case "▬":
                    character = "D";
                    break;

                case "{":
                    character = "E";
                    break;
                case "♠":
                    character = "E";
                    break;
                case "û":
                    character = "E";
                    break;

                case "~":
                    character = "F";
                    break;
                case "¶":
                    character = "F";
                    break;
                case "€":
                    character = "F";
                    break;

                case "<":
                    character = "G";
                    break;
                case "◄":
                    character = "G";
                    break;
                case "ö":
                    character = "G";
                    break;

                case "V":
                    character = "H";
                    break;
                case "â":
                    character = "H";
                    break;
                case "Ñ":
                    character = "H";
                    break;

                case "5":
                    character = "I";
                    break;
                case "♣":
                    character = "I";
                    break;
                case "♂":
                    character = "I";
                    break;

                case "W":
                    character = "J";
                    break;
                case "Ì":
                    character = "J";
                    break;
                case "à":
                    character = "J";
                    break;

                case "[":
                    character = "K";
                    break;
                case "○":
                    character = "K";
                    break;
                case "Ç":
                    character = "K";
                    break;

                case "Ä":
                    character = "L";
                    break;
                case "}":
                    character = "L";
                    break;
                case "‼":
                    character = "L";
                    break;

                case "|":
                    character = "M";
                    break;
                case "`":
                    character = "M";
                    break;
                case "♫":
                    character = "M";
                    break;

                case "⌂":
                    character = "N";
                    break;
                case "Ø":
                    character = "N";
                    break;
                case "ª":
                    character = "N";
                    break;

                case "A":
                    character = "O";
                    break;
                case "☻":
                    character = "O";
                    break;
                case "î":
                    character = "O";
                    break;

                case "T":
                    character = "P";
                    break;
                case "←":
                    character = "P";
                    break;
                case "»":
                    character = "P";
                    break;

                case "$":
                    character = "Q";
                    break;
                case "X":
                    character = "Q";
                    break;
                case "«":
                    character = "Q";
                    break;

                case "?":
                    character = "R";
                    break;
                case "y":
                    character = "R";
                    break;
                case "♀":
                    character = "R";
                    break;

                case "I":
                    character = "S";
                    break;
                case "║":
                    character = "S";
                    break;
                case "ÿ":
                    character = "S";
                    break;

                case @"\":
                    character = "T";
                    break;
                case "∟":
                    character = "T";
                    break;
                case "í":
                    character = "T";
                    break;

                case "B":
                    character = "U";
                    break;
                case "¦":
                    character = "U";
                    break;
                case "•":
                    character = "U";
                    break;

                case "R":
                    character = "V";
                    break;
                case "▲":
                    character = "V";
                    break;
                case "æ":
                    character = "V";
                    break;

                case "#":
                    character = "W";
                    break;
                case "e":
                    character = "W";
                    break;
                case "º":
                    character = "W";
                    break;

                case "§":
                    character = "X";
                    break;
                case "◘":
                    character = "X";
                    break;
                case "Ö":
                    character = "X";
                    break;

                case "s":
                    character = "Y";
                    break;
                case "z":
                    character = "Y";
                    break;
                case "ø":
                    character = "Y";
                    break;

                case "þ":
                    character = "Z";
                    break;
                case "ô":
                    character = "Z";
                    break;
                case "©":
                    character = "Z";
                    break;
            }


            return character;
        }
    }
}