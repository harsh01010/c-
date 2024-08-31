namespace TestProject{
    public class FilterString
    {
        public static void printBetween(String s)
        {
            char[] match = {'(','{','['};
            int closing = 0;
            while(true)
            {
                int opening = s.IndexOfAny(match,closing);
                if(opening == -1) return;
                 char matchEnd = ' ';
                 string curr = s.Substring(opening,1);
                 switch(s)
                 {
                    case "(":
                        matchEnd = ')';
                        break;
                    case "{":
                        matchEnd = '}';
                        break;
                    case "[":
                        matchEnd = ']';
                        break;    
                 }
                closing = s.IndexOf(matchEnd,++opening);
                int length = closing-opening;
                string res = s.Substring(opening,length);
                System.Console.WriteLine(res);

            }

        }
    }
}