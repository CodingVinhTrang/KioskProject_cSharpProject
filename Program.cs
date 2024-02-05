using System.Diagnostics;
using System.Net;
using static CashBox;

namespace KioskProject {
    internal class Program {

        //public static CashBox _cashBox = new CashBox();
        //public static CashBox _cashBox = new CashBox(oneHundreds, fifties, twenties, tens, fives, twos, ones, halfDollars, quarters, dimes, nickels, pennies);
        //public static CashBox _cashBox = new CashBox(0,0,0,0,0,0,0,0,0,0,0,0);
        //public static CashBox _cashBox = new CashBox(0, 1, 0, 0, 0, 0, 0, 0, 0, 0, .20M, 0);
        public static CashBox _cashBox = new CashBox(100.6M, 50, 20, 10, 5, 2, 1, .50M, .25M, .10M, .05M, .01M);

        public static CashBox.PaymentTransaction _transactionRefund = new CashBox.PaymentTransaction();

        static void Main(string[] args) {
            decimal totalItemSum = 0;

            CheckOut(totalItemSum);





        }//end main

        static void AccessCashBox(decimal totalItemSum) {
            string viewBalance = Input("View Balance in Cash Box [Y/N]? : ");
            
            while (viewBalance != "Y" && viewBalance != "N"){
                AccessCashBox(totalItemSum);
            }if (viewBalance == "Y"){
                ViewBalanceCashBox(totalItemSum);
            }else if (viewBalance == "N") {
                string depositToCashBox = Input("Deposit money to Cash Box [Y/N]? : ");
                if (depositToCashBox == "Y") {
                    DepositToCashBox(totalItemSum);
                }else if (depositToCashBox == "N") {
                    CheckOut(totalItemSum);
                }//end else if

            }//end else if 


        }//end AccessCashBox()

        static void ViewBalanceCashBox(decimal totalItemSum) {
            Console.WriteLine();
            Console.WriteLine($"Balance in Cash Box: {_cashBox.GetTotalInCashBox():C}");
            Console.WriteLine($"100s : {_cashBox.OneHundreds:C}");
            Console.WriteLine($"50s  : {_cashBox.Fifties:C}");
            Console.WriteLine($"20s  : {_cashBox.Twenties:C}");
            Console.WriteLine($"10s  : {_cashBox.Tens:C}");
            Console.WriteLine($"5s   : {_cashBox.Fives:C}");
            Console.WriteLine($"2s   : {_cashBox.Twos:C}");
            Console.WriteLine($"1s   : {_cashBox.Ones:C}");
            Console.WriteLine($".50s : {_cashBox.HalfDollars:C}");
            Console.WriteLine($".25s : {_cashBox.Quarters:C}");
            Console.WriteLine($".10s : {_cashBox.Dimes:C}");
            Console.WriteLine($".5s  : {_cashBox.Nickels:C}");
            Console.WriteLine($".1s  : {_cashBox.Pennies:C}");


            Console.WriteLine();
            CheckOut(totalItemSum);
        }//end ViewBalanceCashBox()

        static void DepositToCashBox(decimal totalItemSum) {
            decimal currentDepositInput = 0;
            decimal currentDepositCheck = 0;
            bool depositIsValid = false;
            do {
                depositIsValid = false;
                currentDepositInput = TryInputDecimal("Deposit for $100s : $ ");

                if (currentDepositCheck == (currentDepositInput % 100)) {
                    _cashBox.OneHundreds += currentDepositInput;
                    depositIsValid = true;
                }//end if

            } while (depositIsValid == false);

            

            do {
                depositIsValid = false;
                currentDepositInput = TryInputDecimal("Deposit for $50s : $ ");

                if (currentDepositCheck == (currentDepositInput % 50)) {
                    _cashBox.Fifties += currentDepositInput;
                    depositIsValid = true;
                }//end if

            } while (depositIsValid == false);
            
            do {
                depositIsValid = false;
                currentDepositInput = TryInputDecimal("Deposit for $20s : $ ");

                if (currentDepositCheck == (currentDepositInput % 20)) {
                    _cashBox.Twenties += currentDepositInput;
                    depositIsValid = true;
                }//end if

            } while (depositIsValid == false);
                        
            do {
                depositIsValid = false;
                currentDepositInput = TryInputDecimal("Deposit for $10s : $ ");

                if (currentDepositCheck == (currentDepositInput % 10)) {
                    _cashBox.Tens += currentDepositInput;
                    depositIsValid = true;
                }//end if

            } while (depositIsValid == false);


            do {
                depositIsValid = false;
                currentDepositInput = TryInputDecimal("Deposit for $5s : $ ");

                if (currentDepositCheck == (currentDepositInput % 5)) {
                    _cashBox.Fives += currentDepositInput;
                    depositIsValid = true;
                }//end if

            } while (depositIsValid == false);


            do {
                depositIsValid = false;
                currentDepositInput = TryInputDecimal("Deposit for $2s : $ ");

                if (currentDepositCheck == (currentDepositInput % 2)) {
                    _cashBox.Twos += currentDepositInput;
                    depositIsValid = true;
                }//end if

            } while (depositIsValid == false);



            do {
                depositIsValid = false;
                currentDepositInput = TryInputDecimal("Deposit for $1s : $ ");

                if (currentDepositCheck == (currentDepositInput % 1)) {
                    _cashBox.Ones += currentDepositInput;
                    depositIsValid = true;
                }//end if

            } while (depositIsValid == false);



            do {
                depositIsValid = false;
                currentDepositInput = TryInputDecimal("Deposit for $.50s : $ ");

                if (currentDepositCheck == (currentDepositInput % .50M)) {
                    _cashBox.HalfDollars += currentDepositInput;
                    depositIsValid = true;
                }//end if

            } while (depositIsValid == false);


            do {
                depositIsValid = false;
                currentDepositInput = TryInputDecimal("Deposit for $.25s : $ ");

                if (currentDepositCheck == (currentDepositInput % .25M)) {
                    _cashBox.Quarters += currentDepositInput;
                    depositIsValid = true;
                }//end if

            } while (depositIsValid == false);


            do {
                depositIsValid = false;
                currentDepositInput = TryInputDecimal("Deposit for $.10s : $ ");

                if (currentDepositCheck == (currentDepositInput % .10M)) {
                    _cashBox.Dimes += currentDepositInput;
                    depositIsValid = true;
                }//end if

            } while (depositIsValid == false);


            do {
                depositIsValid = false;
                currentDepositInput = TryInputDecimal("Deposit for $.05s : $ ");

                if (currentDepositCheck == (currentDepositInput % .05M)) {
                    _cashBox.Nickels += currentDepositInput;
                    depositIsValid = true;
                }//end if

            } while (depositIsValid == false);


            do {
                depositIsValid = false;
                currentDepositInput = TryInputDecimal("Deposit for .01s : $ ");

                if (currentDepositCheck == (currentDepositInput % .01M)) {
                    _cashBox.Pennies += currentDepositInput;
                    depositIsValid = true;
                }//end if

            } while (depositIsValid == false);

            /*_cashBox.OneHundreds += TryInputDecimal("Deposit for $100s : $ ");
            _cashBox.Fifties += TryInputDecimal("Deposit for $50s : $ ");
            _cashBox.Twenties += TryInputDecimal("Deposit for $20s : $ ");
            _cashBox.Tens += TryInputDecimal("Deposit for $10s : $ ");
            _cashBox.Fives += TryInputDecimal("Deposit for $5s : $ ");
            _cashBox.Ones += TryInputDecimal("Deposit for $1s : $ ");

            _cashBox.HalfDollars += TryInputDecimal("Deposit for $.50s : $ ");
            _cashBox.Quarters += TryInputDecimal("Deposit for $.25s : $ ");
            _cashBox.Dimes += TryInputDecimal("Deposit for $.10s : $ ");
            _cashBox.Nickels += TryInputDecimal("Deposit for $.05s : $ ");
            _cashBox.Pennies += TryInputDecimal("Deposit for $.01s : $ ");*/

            Console.WriteLine($"Balance in Cash Box: {_cashBox.GetTotalInCashBox():C}");
            Console.WriteLine();
            CheckOut(totalItemSum);
            Console.WriteLine();

        }//end DepositToCashBox


        public static void CheckOut(decimal totalItemSum) {
            string UserCheckOutYesOrNo = Input("Checkout [Y/N]? : ");

            while (UserCheckOutYesOrNo != "Y" && UserCheckOutYesOrNo != "N") {
                CheckOut(totalItemSum);
            } if (UserCheckOutYesOrNo == "Y") {
                Console.WriteLine();
                ItemsCheckOut(totalItemSum);
            }else if (UserCheckOutYesOrNo == "N") {
                AccessCashBox(totalItemSum);
            }//end else if

        }//end Checkout()

        static void ItemsCheckOut(decimal totalItemSum) {
            Console.WriteLine("Scan Items");

            bool scanItems = true;
            List<decimal> listOfItems = new List<decimal>();
            
            while (scanItems == true){

                for (int index = 1; index<= listOfItems.Count+1 & scanItems==true; index++) {
                   
                    decimal currentItems = TryInputDecimal($"Item{index}: $ ");

                    while (currentItems < 0) {
                        currentItems = TryInputDecimal($"Item{index}: $ ");
                    }//end while

                     listOfItems.Add(currentItems);

                    if (currentItems == 0) {
                        scanItems = false;
                    }//end if
                }//end for
            }//end while

            if (scanItems == false) {
                Console.WriteLine("--------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Total: {listOfItems.Sum():C}");
                totalItemSum = listOfItems.Sum();
                Console.ResetColor();
                Console.WriteLine();

                CashOrCard(totalItemSum);
            }//end if

        }//end ItemsCheckOut()



        static void CashOrCard(decimal totalItemSum) {

            string PayCash = Input("Cash [Y/N]? : ");

            while (PayCash != "Y" && PayCash != "N") {
                CashOrCard(totalItemSum);
            }if (PayCash == "Y") {
                PaymentCash(totalItemSum);
            } else if (PayCash == "N") {

                string PayCard = Input("Card [Y/N]? : ");

                while (PayCard != "Y" && PayCard != "N") {
                    CashOrCard(totalItemSum);
                }if (PayCard == "Y") {
                        PaymentCard(totalItemSum);

                } else if (PayCard == "N") {
                        CashOrCard(totalItemSum);
                }//end else if

            }//end else if


        }//end CashOrCard()


        public static void PaymentCash(decimal totalItemSum) {
            Console.WriteLine();
            Console.WriteLine("Insert Cash");
            Console.WriteLine($"Balance : {totalItemSum:C}");
            
            bool BalanceZero = false;
            decimal Payment = 0;
            decimal totalPayment = 0;


            //100, 50, 20, 10, 2, 1, .50, .25, .10, .05, .01

            while (BalanceZero == false) {
                Payment = 0;
                for (int index  = 1; Payment <= totalItemSum && BalanceZero==false; index++) {
 
                    Payment = TryInputDecimal($"Payment{index}: $ ");

                    if (Payment == 100) {
                        _cashBox.OneHundreds += 100;
                        _transactionRefund.OneHundredsRefund += Payment;
                        totalPayment += Payment;

                        totalItemSum = totalItemSum - Payment;
                        Console.WriteLine($"Balance : {totalItemSum:C}");
                        if (totalItemSum <= 0) {
                            BalanceZero = true;
                        }//end if

                    } else if (Payment == 50) {
                        _cashBox.Fifties += 50;
                        _transactionRefund.FiftiesRefund += Payment;
                        totalPayment += Payment;

                        totalItemSum = totalItemSum - Payment;
                        Console.WriteLine($"Balance : {totalItemSum:C}");
                        if (totalItemSum <= 0) {
                            BalanceZero = true;
                        }//end if

                    } else if (Payment == 20) {
                        _cashBox.Twenties += 20;
                        _transactionRefund.TwentiesRefund += Payment;
                        totalPayment += Payment;

                        totalItemSum = totalItemSum - Payment;
                        Console.WriteLine($"Balance : {totalItemSum:C}");
                        if (totalItemSum <= 0) {
                            BalanceZero = true;
                        }//end if

                    } else if (Payment == 10) {
                        _cashBox.Tens += 10;
                        _transactionRefund.TensRefund += Payment;
                        totalPayment += Payment;

                        totalItemSum = totalItemSum - Payment;
                        Console.WriteLine($"Balance : {totalItemSum:C}");
                        if (totalItemSum <= 0) {
                            BalanceZero = true;
                        }//end if

                    } else if (Payment == 5) {
                        _cashBox.Fives += 5;
                        _transactionRefund.FivesRefund += Payment;
                        totalPayment += Payment;

                        totalItemSum = totalItemSum - Payment;
                        Console.WriteLine($"Balance : {totalItemSum:C}");
                        if (totalItemSum <= 0) {
                            BalanceZero = true;
                        }//end if
                    } else if (Payment == 2) {
                        _cashBox.Twos += 2;
                        _transactionRefund.TwosRefund += Payment;
                        totalPayment += Payment;

                        totalItemSum = totalItemSum - Payment;
                        Console.WriteLine($"Balance : {totalItemSum:C}");
                        if (totalItemSum <= 0) {
                            BalanceZero = true;
                        }//end if

                    } else if (Payment == 1) {
                        _cashBox.Ones += 1;
                        _transactionRefund.OnesRefund += Payment;
                        totalPayment += Payment;

                        totalItemSum = totalItemSum - Payment;
                        Console.WriteLine($"Balance : {totalItemSum:C}");
                        if (totalItemSum <= 0) {
                            BalanceZero = true;
                        }//end if

                    } else if (Payment == .50M) {
                        _cashBox.HalfDollars += .50M;
                        _transactionRefund.HalfDollarsRefund += Payment;
                        totalPayment += Payment;

                        totalItemSum = totalItemSum - Payment;
                        Console.WriteLine($"Balance : {totalItemSum:C}");
                        if (totalItemSum <= 0) {
                            BalanceZero = true;
                        }//end if

                    } else if (Payment == .25M) {
                        _cashBox.Quarters += .25M;
                        _transactionRefund.QuartersRefund += Payment;
                        totalPayment += Payment;

                        totalItemSum = totalItemSum - Payment;
                        Console.WriteLine($"Balance : {totalItemSum:C}");
                        if (totalItemSum <= 0) {
                            BalanceZero = true;
                        }//end if

                    } else if (Payment == .10M) {
                        _cashBox.Dimes += .10M;
                        _transactionRefund.DimesRefund += Payment;
                        totalPayment += Payment;

                        totalItemSum = totalItemSum - Payment;
                        Console.WriteLine($"Balance : {totalItemSum:C}");
                        if (totalItemSum <= 0) {
                            BalanceZero = true;
                        }//end if

                    } else if (Payment == .05M) {
                        _cashBox.Nickels += .05M;
                        _transactionRefund.NickelsRefund += Payment;
                        totalPayment += Payment;

                        totalItemSum = totalItemSum - Payment;
                        Console.WriteLine($"Balance : {totalItemSum:C}");
                        if (totalItemSum <= 0) {
                            BalanceZero = true;
                        }//end if

                    } else if (Payment == .01M) {
                        _cashBox.Pennies += .01M;
                        _transactionRefund.PenniesRefund += Payment;
                        totalPayment += Payment;

                        totalItemSum = totalItemSum - Payment;
                        Console.WriteLine($"Balance : {totalItemSum:C}");
                        if (totalItemSum <= 0) {
                            BalanceZero = true;
                        }//end if

                    } else {
                        Console.WriteLine("Invalid Cash");
                    }//end else

                }//end for

            }//end while

            if (BalanceZero == true) {
                if (totalItemSum == 0) {
                    Console.WriteLine("**Receipt Printed**");
                    Console.WriteLine();
                    CheckOut(0);

                } else if (totalItemSum < 0) {
                    Console.WriteLine();
                    Console.WriteLine($"Total Inserted Cash: {totalPayment:C}");
                    GiveChange(totalItemSum);
                }//end else if
            }//end if


        }//end PaymentCash()


        static void GiveChange(decimal totalItemSum) {
            Console.WriteLine();
            Console.WriteLine("Dispensing Change");

            Console.WriteLine("------------");

            _cashBox.DispenseChange(totalItemSum);

            Console.WriteLine();
            CheckOut(0);
        }//end GiveChange()



        public static void PaymentCard(decimal totalItemSum) {
            Console.WriteLine();
            Console.WriteLine("Insert/Swipe/Tap Card");

            creditcard.InsertCard(totalItemSum);


        }//end PaymentCard()


        #region hide Old Dispense code
        /*static void DispenseChange(double totalItemSum) {
            Console.WriteLine();
            Console.WriteLine("Dispense");

            bool ChangeZero = false;
            double RemainingBalance = 0;

            while (ChangeZero == false) {

                if (Math.Abs(RemainingBalance = Math.Abs(totalItemSum)) >= 100 && ChangeZero == false) {
                    _cashBox.OneHundreds = (int)RemainingBalance / 100;
                    RemainingBalance -= _cashBox.OneHundreds;
                    Console.WriteLine($"Dispense 100s: {_cashBox.OneHundreds}");
                    if (RemainingBalance == 0) {
                        ChangeZero = true;
                    }//end if
                }else if (Math.Abs(RemainingBalance = Math.Abs(totalItemSum)) >= 50 && ChangeZero == false) {
                    _cashBox.Fifties = (int)RemainingBalance / 50;
                    RemainingBalance -= _cashBox.Fifties;
                    Console.WriteLine($"Dispense 50s: {_cashBox.Fifties}");
                    if (RemainingBalance == 0) {
                        ChangeZero = true;
                    }//end if
                } else if (Math.Abs(RemainingBalance = totalItemSum) >= 20 && ChangeZero == false) {
                    _cashBox.Twenties = (int)RemainingBalance / 20;
                    RemainingBalance -= _cashBox.Twenties;
                    Console.WriteLine($"Dispense 20s: {_cashBox.Twenties}");
                    if (RemainingBalance == 0) {
                        ChangeZero = true;
                    }//end if
                } else if (Math.Abs(RemainingBalance = Math.Abs(totalItemSum)) >= 10 && ChangeZero == false) {
                    _cashBox.Tens = (int)RemainingBalance / 10;
                    RemainingBalance -= _cashBox.Tens;
                    Console.WriteLine($"Dispense 10s: {_cashBox.Tens}");
                    if (RemainingBalance == 0) {
                        ChangeZero = true;
                    }//end if
                } else if (Math.Abs(RemainingBalance = Math.Abs(totalItemSum)) >= 5 && ChangeZero == false) {
                    _cashBox.Fives = (int)RemainingBalance / 5;
                    RemainingBalance -= _cashBox.Fives;
                    Console.WriteLine($"Dispense 5s: {_cashBox.Fives}");
                    if (RemainingBalance == 0) {
                        ChangeZero = true;
                    }//end if
                } else if ((RemainingBalance = Math.Abs(totalItemSum)) >= 2 && ChangeZero == false) {
                    _cashBox.Twos = (int)RemainingBalance / 2;
                    RemainingBalance -= _cashBox.Twos;
                    Console.WriteLine($"Dispense 2s: {_cashBox.Twos}");
                    if (RemainingBalance == 0) {
                        ChangeZero = true;
                    }//end if
                } else if ((RemainingBalance = Math.Abs(totalItemSum)) >= 1 && ChangeZero == false) {
                    _cashBox.Ones = (int)RemainingBalance / 1;
                    RemainingBalance -= _cashBox.Ones;
                    Console.WriteLine($"Dispense 1s: {_cashBox.Ones}");
                    if (RemainingBalance == 0) {
                        ChangeZero = true;
                    }//end if
                } else if ((RemainingBalance = Math.Abs(totalItemSum)) >= .50 && ChangeZero == false) {
                    _cashBox.HalfDollars = (double)RemainingBalance / .50;
                    RemainingBalance -= _cashBox.HalfDollars;
                    Console.WriteLine($"Dispense .50s: {_cashBox.HalfDollars}");
                    if (RemainingBalance == 0) {
                        ChangeZero = true;
                    }//end if
                } else if ((RemainingBalance = Math.Abs(totalItemSum)) >= .25 && ChangeZero == false) {
                    _cashBox.Quarters = (double)RemainingBalance / .25;
                    RemainingBalance -= _cashBox.Quarters;
                    Console.WriteLine($"Dispense .25s: {_cashBox.Quarters}");
                    if (RemainingBalance == 0) {
                        ChangeZero = true;
                    }//end if
                } else if ((RemainingBalance = Math.Abs(totalItemSum)) >= .10 && ChangeZero == false) {
                    _cashBox.Dimes = (double)RemainingBalance / .10;
                    RemainingBalance -= _cashBox.Dimes;
                    Console.WriteLine($"Dispense .10s: {_cashBox.Dimes}");
                    if (RemainingBalance == 0) {
                        ChangeZero = true;
                    }//end if
                } else if ((RemainingBalance = Math.Abs(totalItemSum)) >= .05 && ChangeZero == false) {
                    _cashBox.Nickels = (double)RemainingBalance / .05;
                    RemainingBalance -= _cashBox.Nickels;
                    Console.WriteLine($"Dispense .05s: {_cashBox.Nickels}");
                    if (RemainingBalance == 0) {
                        ChangeZero = true;
                    }//end if
                } else if ((RemainingBalance = Math.Abs(totalItemSum)) >= .01 && ChangeZero == false) {
                    _cashBox.Pennies = (double)RemainingBalance / .01;
                    RemainingBalance -= _cashBox.Pennies;
                    Console.WriteLine($"Dispense .01s: {_cashBox.Ones}");
                    if (RemainingBalance == 0) {
                        ChangeZero = true;
                    }//end if
                }//end if

            }//end while


            if (ChangeZero == true) {
                Console.WriteLine("**Receipt Printed **");



                CheckOut(totalItemSum);
            }//end if

        }//end DispenseChange()*/

        #endregion hide Old Dispense code


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


    }//end class
}//end namespace