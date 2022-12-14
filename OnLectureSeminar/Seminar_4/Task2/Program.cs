// See https://aka.ms/new-console-template for more information
string m1 = "\nThe cursor is {0}.\nType any text then press Enter. " +
                "Type '+' in the first column to show \n" +
                "the cursor, '-' to hide the cursor, " +
                "or lowercase 'x' to quit:";
    string s;
    bool saveCursorVisibile;
    int  saveCursorSize;
//
    Console.CursorVisible = true; // Initialize the cursor to visible.
    saveCursorVisibile = Console.CursorVisible;
    saveCursorSize  = Console.CursorSize;
    Console.CursorSize = 100;     // Emphasize the cursor.

    while(true)
        {
        Console.WriteLine(m1,
                         ((Console.CursorVisible == true) ?
                           "VISIBLE" : "HIDDEN"));
        s = Console.ReadLine()!;
        if (String.IsNullOrEmpty(s) == false)
            if (s[0] == '+')
                Console.CursorVisible = true;
            else if (s[0] == '-')
                Console.CursorVisible = false;
            else if (s[0] == 'x')
                break;
        }
    Console.CursorVisible = saveCursorVisibile;
    Console.CursorSize    = saveCursorSize;