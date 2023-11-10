namespace LRTapp
{
    class PatientData
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string DominantHand { get; set; }
        public string Note { get; set; }
        public MeasuredData MesureDataRight { get; set; }
        public MeasuredData MesureDataLeft { get; set; }

        public PatientData(string name, string dHand, string gender, string age, string height, string weight, string note) 
        {
            Name = name;
            Age = age;
            Gender = gender;
            DominantHand = dHand;
            Height = height;
            Weight = weight;
            Note = note;
            MesureDataRight = new MeasuredData();
            MesureDataLeft = new MeasuredData();
        }
    }
}
