using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class ActionResolver : Resolver
    {
        public MessageLogger Logger { get; set; }

        public ActionResolver()
        {
            Logger = new MessageLogger();
        }

        private void WriteErrorMessage(string message)
        {
            var msg = new Message()
            {
                MessageText = message
            };
            Logger.Write(msg);
        }

        private string ConvertToBinary(int number)
        {
            string binaryNumber = string.Empty;

            // Algorithm for converting a decimal number to binary
            for (int i = 0; number > 0; i++)
            {
                binaryNumber = number % 2 + binaryNumber;
                number /= 2;
            }

            return binaryNumber;
        }

        //private void Uppercase(String phrase)
        //{

        //}

        private string Reverse(String text)
        {
            string reversedString = string.Empty;

            for (int i = text.Length - 1; i >= 0 ; i--)
            {
                reversedString += text[i];
            }

            return reversedString;
        }

        public override ActionResponse Execute(ActionRequest actionRequest)
        {
            var actionResponse = new ActionResponse()
            {
                RequestID = actionRequest.RequestID
            };

            switch (actionRequest.Action)
            {
                case ActionEnum.Convert:
                    try
                    {
                        int number = Convert.ToInt32(actionRequest.Input);
                        actionResponse.Output = ConvertToBinary(number);
                    }
                    catch (Exception ex)
                    {
                        WriteErrorMessage(ex.Message);
                    }
                    break;

                case ActionEnum.Uppercase:
                    break;

                case ActionEnum.Reverse:
                    try
                    {
                        string text = Convert.ToString(actionRequest.Input);
                        actionResponse.Output = Reverse(text);
                    }
                    catch (Exception ex)
                    {
                        WriteErrorMessage(ex.Message);
                    }
                    break;

                default:
                    break;
            }

            return actionResponse;

        }
    }
}
