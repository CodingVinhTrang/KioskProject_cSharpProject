
using KioskProject;

class creditcard {


    public static void InsertCard(decimal totalItemSum) {
        Console.WriteLine();
        char[] userInputCardArray;

            string userInputCard = Input("Insert Card number:");
            userInputCardArray = userInputCard.ToCharArray();

            //CHECK TO SEE IF CARD NUMBER IS A VALID INPUT
   
                 for (int index = 0; index < userInputCardArray.Length; index++) {
                     if (userInputCardArray[index] >= 48 && userInputCardArray[index] <= 57 && userInputCardArray.Length < 17) {
                         if ( userInputCardArray.Length-1 == index ) {
                             IdentifyCardVendor(userInputCardArray,totalItemSum);
                         } else {

                         }//end else
 
                     } else {
                         Console.WriteLine("Invalid Input");
                         Console.WriteLine();
                         ContinueCardOrCancel(totalItemSum);

                     }//end else
                 }//end for

    }//end InsertCard()


    static void IdentifyCardVendor(char[] userInputCardArray,decimal totalItemSum) {

        //CHECK IF A AMERICAN EXPRESS
        if (userInputCardArray.Length == 15) {
            if (userInputCardArray[0] == '3') {
                if (userInputCardArray[1] == '4' || userInputCardArray[1] == '7') {
                    Console.WriteLine("American Express");
                    ValidateCard(userInputCardArray);
                } else {
                    Console.WriteLine("Invalid Card");
                    InsertCard(totalItemSum);
                }//end else
            }//end if


        } else if (userInputCardArray.Length == 16 || userInputCardArray.Length == 13) {
            if ((userInputCardArray.Length == 16 || userInputCardArray.Length == 13) && userInputCardArray[0] == '4') {
                Console.WriteLine("Visa");
                
               if (ValidateCard(userInputCardArray) == true) {

                    if (CashBackYesOrNo() == true) {
                        PayYesCashBack(userInputCardArray, totalItemSum);
                    } else {
                        PayNoCashBack(userInputCardArray,totalItemSum);
                    }//end if

                } else {
                    ContinueCardOrCancel(totalItemSum);
                }//end else


            } else if (userInputCardArray.Length == 16 && userInputCardArray[0] == '5') {
                Console.WriteLine("MasterCard");
                ValidateCard(userInputCardArray);
            } else if (userInputCardArray.Length == 16 && userInputCardArray[0] == '6') {
                Console.WriteLine("Discover");
                ValidateCard(userInputCardArray);
            } else {
                Console.WriteLine("Invalid Card");
                InsertCard(totalItemSum);
            }//end else


        }//end else if

    }//end IdentifyCardVendor()

    public static bool ValidateCard(char[] userInputCardArray) {

        int checkRightToLeftOtherDigitsSum = 0;
        int checkLeftToRightOtherDigitsSum = 0;
        int checkDigitSum = 0;

        for (int index = userInputCardArray.Length - 2; index >= 0; index-=2) {
            
            int currentDigit = userInputCardArray[index]-'0';
            if (currentDigit > 4) {
                checkRightToLeftOtherDigitsSum += currentDigit * 2 - 9;
            } else {
                checkRightToLeftOtherDigitsSum += currentDigit * 2;
            }//end else

        }//end for

        for (int index = 1; index < userInputCardArray.Length; index+=2) {

            int currentDigit = userInputCardArray[index]-'0';
            checkLeftToRightOtherDigitsSum += currentDigit;

        }//end for

        checkDigitSum = checkRightToLeftOtherDigitsSum + checkLeftToRightOtherDigitsSum;
        
        checkDigitSum = (checkDigitSum % 10);

        if (checkDigitSum == 0) {
            Console.WriteLine("Valid Card");
            Console.WriteLine();
            return true;
        } else {
            Console.WriteLine("Invalid Card");
            Console.WriteLine();
            return false;
            
        }//end else

    }//end  ValidateCard()

    static void ContinueCardOrCancel(decimal totalItemSum) {
        string continueCardOrExit = Input("Continue [Y/N]? ");
        while (continueCardOrExit != "Y" && continueCardOrExit != "N") {
            continueCardOrExit = Input("Continue [Y/N]? ");
        }
        if (continueCardOrExit == "Y") {
            InsertCard(totalItemSum);
        } else if (continueCardOrExit == "N") {
            Console.WriteLine("Transaction Canceled");
            Console.WriteLine();
            Program.CheckOut(0);
        }//end else if  

    }//end ContinueCardOrCancel()

    static bool CashBackYesOrNo() {

        string cashBackYesOrNo = Input("Would you like cashback [Y/N]? ");
        while (cashBackYesOrNo != "Y" && cashBackYesOrNo != "N") {
            cashBackYesOrNo = Input("Continue [Y/N]? ");
        }
        if (cashBackYesOrNo == "Y") {
            return true;
        } else if (cashBackYesOrNo == "N") {
            return false;

        }//end else if   
        return false;
    }//end CashBAckYesOrNo()



    public static void PayNoCashBack(char[] account_number, decimal totalItemSum) {
        Console.WriteLine("No Cash Back");
        string[] moneyRequestReturnData;
        moneyRequestReturnData = MoneyRequest(account_number, totalItemSum);

        Console.WriteLine($"Total Amount to charge: {totalItemSum:C}");
        Console.WriteLine("Processing Card");
        for (int index = 1; index < moneyRequestReturnData.Length; index++) {

            if (moneyRequestReturnData[1] == "Approved") {
            Console.WriteLine($"{moneyRequestReturnData[1]}");
                totalItemSum = 0;
                Console.WriteLine($"Balance: {totalItemSum:C}");
                Console.WriteLine("**Receipt Printed**");
            } else if (moneyRequestReturnData[1] == "Declined") {
                Console.WriteLine($"{moneyRequestReturnData[1]}");
                Console.WriteLine();
                ContinueCardOrCancel(totalItemSum);

            } else {

                decimal moneyRequestReturnDataDecimal = decimal.Parse(moneyRequestReturnData[1]);
                Console.WriteLine($"Amount Approved: {moneyRequestReturnDataDecimal:C}");

                totalItemSum -= moneyRequestReturnDataDecimal;
                Console.WriteLine();

                string payRemainingInCash = Input("Would you like to pay the remaining in balance in cash [Y/N]? ");

                while (payRemainingInCash != "Y" && payRemainingInCash != "N") {
                    payRemainingInCash = Input("Continue [Y/N]? ");
                }
                if (payRemainingInCash == "Y") {
                    Program.PaymentCash(totalItemSum);
                } else if (payRemainingInCash == "N") {
                    Console.WriteLine("Transaction Canceled");
                    Console.WriteLine();
                    Program.CheckOut(0);
                }//end
            }//end if

        }//end for

        Console.WriteLine();
        Program.CheckOut(0);

    }//end PayNoCashBack()

    static void PayYesCashBack(char[] account_number, decimal totalItemSum) {
        Console.WriteLine("Yes Cash Back");


        decimal cashAmount = TryInputDecimal("Amount of cashback: $ ");
        while (cashAmount < 0) {
            cashAmount = TryInputDecimal("Amount of cashback: $ ");
        }//end if


        totalItemSum += cashAmount;

        string[] moneyRequestReturnData;
        moneyRequestReturnData = MoneyRequest(account_number, totalItemSum);

        Console.WriteLine($"Total Amount to charge: {totalItemSum:C}");
        Console.WriteLine("Processing Card");

        for (int index = 1; index < moneyRequestReturnData.Length; index++) {

            if (moneyRequestReturnData[1] == "Approved") {
                totalItemSum = 0;
                Console.WriteLine($"Balance: {totalItemSum:C}");
                Console.WriteLine("**Receipt Printed**");
            } else if (moneyRequestReturnData[1] == "Declined") {
                Console.WriteLine();
                totalItemSum -= cashAmount;
                Console.WriteLine($"{moneyRequestReturnData[1]}");
                Console.WriteLine();
                ContinueCardOrCancel(totalItemSum);
            } else {

                    decimal moneyRequestReturnDataDecimal = decimal.Parse(moneyRequestReturnData[1]);
                    Console.WriteLine($"Amount Approved: {moneyRequestReturnDataDecimal:C}");

                    totalItemSum -= moneyRequestReturnDataDecimal;
                    Console.WriteLine();
                    string payRemainingInCash = Input("Would you like to pay the remaining in balance in cash [Y/N]? ");

                    while (payRemainingInCash != "Y" && payRemainingInCash != "N") {
                        payRemainingInCash = Input("Continue [Y/N]? ");
                    }
                    if (payRemainingInCash == "Y") {
                        Program.PaymentCash(totalItemSum);
                    } else if (payRemainingInCash == "N") {
                        Console.WriteLine("Transaction Canceled");
                        Console.WriteLine();
                        Program.CheckOut(0);
                    }//end
            }//end if
        }//end if

        Console.WriteLine();
        Program.CheckOut(0);


    }//end PayYesCashBack()


    static string[] MoneyRequest(char[] account_number, decimal amount) {
        string account_number1 = new string(account_number);
        Random rnd = new Random();
        //50% CHANCE TRANSACTION PASSES OR FAILS
        bool pass = rnd.Next(100) < 50;
        //50% CHANCE THAT A FAILED TRANSACTION IS DECLINED
        bool declined = rnd.Next(100) < 50;

        if (pass) {
            //return new string[] { account_number1, amount.ToString() };
            return new string[] { account_number1, "Approved" };
        } else {
            if (!declined) {
                return new string[] { account_number1, (amount / rnd.Next(2, 6)).ToString() };
            } else {
                return new string[] { account_number1, "Declined" };
            }//end if
        }//end if
    }//end if



    #region HELPER FUNCTION
    static void EndProgramLayout() {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine();
        Console.WriteLine("------------End of Program--------------");
        Console.WriteLine();
        Console.ResetColor();
    }//end EndProgramLayout

    static void Print(string message) {
        Console.Write(message);
    }//end helper subfunction Print
    static string Input(string message) {
        Console.Write(message);
        return Console.ReadLine();
    }//end help subfunction Input

    static decimal InputDecimal(string message) {
        string value = Input(message);
        return decimal.Parse(value);
    }//end helper subfunction Inputdecimal

    static double InputDouble(string message) {
        string value = Input(message);
        return double.Parse(value);
    }//end helper subfunction InputDouble

    static int InputInt(string message) {
        string value = Input(message);
        return int.Parse(value);
    }//end helper subfunction InputInt

    //------TRY PARSE------
    static int TryInputInt(string message) {
        //VARIABLES
        int parsedValue = 0;
        bool gotParsed = false;

        //VALIDATION LOOP UNTIL VALID INT HAS BEEN SUBMITTED
        do {
            gotParsed = int.TryParse(Input(message), out parsedValue);
        } while (gotParsed == false);

        //RETURN PARSED VALUE
        return parsedValue;
    }//end function TryInputInt - Parse Int

    static double TryInputDouble(string message) {
        double parsedValue = 0;
        bool gotParsed = false;

        do {
            gotParsed = double.TryParse(Input(message), out parsedValue);
        } while (gotParsed == false);

        return parsedValue;
    }//end function TryInputDouble

    static decimal TryInputDecimal(string message) {
        decimal parsedValue = 0;
        bool gotParsed = false;

        do {
            gotParsed = decimal.TryParse(Input(message), out parsedValue);
        } while (gotParsed == false);

        return parsedValue;
    }//end function TryInputDecimal



    #endregion HELPER FUNCTION

}//end class creditcard
