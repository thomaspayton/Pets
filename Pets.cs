{
    public class Pet
    {

        public string PetType;
        public string PetName;
        public string PetOwner;
        public int PetWeight;

        public int getPetWeight()
        {
            return PetWeight;
        }

    }
    public class Dogs : Pet
    {
    }
    public class Cats : Pet
    {
    }
}

