using System;
using System.Collections.Generic;

namespace Polymorfism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UserError> UEList = new List<UserError>();

            NumericInputError NIErr = new NumericInputError();
            UEList.Add(NIErr);

            TextInputError TIErr = new TextInputError();
            UEList.Add(TIErr);

            NullInputError NullIErr = new NullInputError();
            UEList.Add(NullIErr);

            OutOfRangeError OORErr = new OutOfRangeError();
            UEList.Add(OORErr);

            DivideByZero DZErr = new DivideByZero();
            UEList.Add(DZErr);
            

            foreach (UserError error in UEList)
            {
                Console.WriteLine(error.UEMessage());
            }

            // F: Varför är polymorfism viktigt att behärska?
            // Polymorfism är en av de viktigaste delarna av OOP, efter inkapsling
            // och arv. Det är även en av nyckeldelarna i c#, då varje typ vi jobbar
            // med är polymorfa - de ärver från Object men har sina egna implementationer.
            // Det är både vitkigt för att förstå C# kod, och hur den funkar - och även
            // för att kunna skriva effetkivare kod. 

            // F: Hur kan polymorfism förändra och förbättra kod via en bra struktur?
            // Polymorfism effektiviserar den kod vi skriver, då vi inte behöver skriva
            // funktionaliteter för massor med klasser flera gånger om - om det är något
            // som de kan dela via basklassen. Med nyckelord som virtual och override
            // kan vi dock försäkra att om en klass behöver implementera en metod, men
            // på ett någorlunda eget sätt, så kan detta göras - men vi behöver inte
            // skriva om all kod, uppfinna hjulet igen, för att göra det. 

            // F: Vad är det för en skillnad på en Abstrakt klass och ett Interface?
            // Det är mycket som skiljer de båda åt:
            // - Abstrakta klasser kan ha constructors, fields och implementationer av
            // icke-abstrakta metoder - interfaces kan ej ha constructors, fields, och 
            // kan endast ha deklarationer av metoder, ej implementeringar av dem
            // - Abstratka klasser kan vara publika, privata, etc. - interfaces kan endast
            // vara (och är av default) publika
            // - Om en klass ärver av en abstrakt klass kan den ej ärva av ytterligare abstrakta
            // klasser - en klass kan dock ärva av ett flertal interfaces

        }
    }
}
