using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eprov_Del2
{
    class Car
    {
        public int passengers;
        public int contrabandAmount;
        public bool alreadyChecked;
        public Random generator = new Random();

        public Car()
        {


        }

        static bool Examine(Car carThatIsBeingIdentified)
        {
            Random generator = new Random();
            //Här tar vi ut mängden stöldgods för att modifiera oddsen att dem blir hittade.
            int contraBands = carThatIsBeingIdentified.contrabandAmount;
            //Bilen har blivit eximinerad
            carThatIsBeingIdentified.alreadyChecked = true;
            //Om det inte finns några stöldgods kommer de aldrig att bli hittade (uppenbarligen)
            if (contraBands == 0)
            {
                return false;
            }
            //Om det finns mer än 0 stöldgods finns det en chancs att bli hittad.
            else
            {
                int oddsOfBeingFoundOut = 60 + contraBands * 10;
                int randomizer = generator.Next(1, 100);
                //Om det finns 4 stöldgods i bilen så blir oddsens värde 100, alltså kommer det aldrig att vara lägre än det slumpade talet
                //...Ifall det blir lägre dock så missar examine metoden det och returnerar false.
                if (oddsOfBeingFoundOut < randomizer)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

    }
}
