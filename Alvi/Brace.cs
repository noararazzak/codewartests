using System;

namespace CodewarsTest.Alvi
{
    class Brace
    {
        public static bool validBraces(String braces)
        {
            Bracket[] braceTypes = new Bracket[] {new Bracket('(', ')'),
                                                new Bracket('{', '}'),
                                                new Bracket('[', ']')};

            for (int i = 0; i < braces.Length; i++)
            {
                foreach (Bracket braceType in braceTypes)
                {
                    if (braceType.IsOpen)
                    {
                        if (braceType.CloseType == braces[i])
                        {

                            foreach (Bracket otherBrace in braceTypes)
                            {
                                if (otherBrace != braceType)
                                {
                                    if (otherBrace.StartIndex > braceType.StartIndex)
                                    {
                                        return false;
                                    }
                                }
                            }

                            braceType.OpenCount--;
                        }
                        else if (braceType.OpenType == braces[i])
                        {
                            braceType.OpenCount++;
                        }
                            
                    }

                    else
                    {
                        if (braceType.OpenType == braces[i])
                        {
                            braceType.OpenCount++;
                            braceType.StartIndex = i;
                        }
                        else if (braceType.CloseType == braces[i])
                            return false;
                    }
                }
            }

            if (braceTypes[0].IsOpen || braceTypes[1].IsOpen || braceTypes[2].IsOpen)
                return false;
            else
                return true;
        }

        private class Bracket
        {
            private char _openType;
            public char OpenType { get { return _openType; } }

            private char _closeType;
            public char CloseType { get { return _closeType; } }

            private int _startIndex;
            public int StartIndex { get => _startIndex; set => _startIndex = value; }

            private bool _isOpen;
            public bool IsOpen { get { return _isOpen; } }

            private int _openCount;
            public int OpenCount
            {
                get { return _openCount; }
                set
                {
                    _openCount = value;

                    if (_openCount > 0)
                    {
                        _isOpen = true;
                    }
                    else
                    {
                        _isOpen = false;
                        _startIndex = -1;
                    }

                }
            }

            public Bracket(char inputOpenType, char inputCloseType)
            {
                _openType = inputOpenType;
                _closeType = inputCloseType;
                _openCount = 0;
                _isOpen = false;
                _startIndex = -1;
            }
        }
    }
}
