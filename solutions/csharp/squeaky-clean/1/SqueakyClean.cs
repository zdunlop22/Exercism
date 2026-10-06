using System.Text;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder("", 50);
        bool upperNext=false;
        foreach(char c in identifier)
        {
            if(c=='-')
                upperNext=true;
            else if(Char.IsControl(c))
            {
                sb.Append("CTRL");
                continue;
            }
            else if(upperNext==true)
            {
                sb.Append(char.ToUpper(c));
                upperNext=false;
            }
            else if (c >= 'α' && c <= 'ω')
            {
                continue; 
            }
            else if (Char.IsLetter(c) || Char.IsWhiteSpace(c))
                sb.Append(c);
            
                
        }
        sb.Replace(' ', '_');
        return sb.ToString();
    }
}
