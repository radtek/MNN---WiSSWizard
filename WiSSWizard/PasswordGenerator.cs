namespace Actemium.WiSSWizard
{
    public class PasswordGenerator
    {
        private const string ALLVALIDPASSWORDCHARS = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789~!@#$%^&*_-+=|(){}[]<>?";
        private const string VALIDLETTERSUPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string VALIDLETTERSLOWER = "abcdefghijklmnopqrstuvwxyz";
        private const string VALIDNUMBERS = "0123456789";
        private const string VALIDCHARS = "~!@#$%^&*_-+=|(){}[]<>?"; // " and \ does not include this, can give problems with the strings
        private static System.Random RandNum = new System.Random();
        

        public string GeneratePassword(int length)
        {
            int count = 0;
            string temp = "";
            string result = "";
            temp += VALIDLETTERSUPPER.Substring(RandNum.Next(VALIDLETTERSUPPER.Length), 1);
            temp += VALIDLETTERSLOWER.Substring(RandNum.Next(VALIDLETTERSLOWER.Length ), 1);
            temp += VALIDNUMBERS.Substring(RandNum.Next(VALIDNUMBERS.Length ), 1);
            temp += VALIDCHARS.Substring(RandNum.Next(VALIDCHARS.Length ), 1);
            count = 4;

            if (length < 4)
            {
                for (int i = 0; i<length; i++)
                {
                    string sub = temp.Substring(RandNum.Next(temp.Length), 1);
                    result += sub;
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (temp[j] == sub[0])
                        {
                            temp = temp.Remove(j, 1);
                            break;
                        }
                    }
                }
                return result;

            }

            for (int i = count; i < length; i++)
            {
                string l = ALLVALIDPASSWORDCHARS.Substring(RandNum.Next(ALLVALIDPASSWORDCHARS.Length), 1);
                if (!temp.Contains(l))
                {
                    temp += l;
                }
                else
                {
                    i--;
                }
            }

            int stringLength = temp.Length;

            for(int j = 0; j < stringLength;j++)
            {
                string sub = temp.Substring(RandNum.Next(temp.Length),1);
                result += sub;
                for (int k = 0; k < temp.Length; k++)
                {
                    if (temp[k] == sub[0])
                    {
                       temp = temp.Remove(k, 1);
                        break;
                    }
                }

            }

            return result;
            
        }
    }
}
