using System;

namespace Adrift
{
    class Player
    {
        public char location = 'C';
        public bool keepGoing = true;
        public bool secondaryReactorFixed;
        public string[] inventory; 
        public bool hydropaunicsFixed;
        public bool AIreset;
        public bool navigationFixed;
        public bool storageFuseTaken;
        public bool storageFilterTaken;
        public bool engineRoomFuseTaken;
        public bool primaryReactorFuseTaken;
        public bool leafletTaken;
    }
}