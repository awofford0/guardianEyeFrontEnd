using guardianEyeMAUI.Models;

namespace guardianEyeMAUI
{
    public class MainPageModel
    {
        public IList<Detection> Detections { get; private set; }

        public MainPageModel()
        {
            Detections = new List<Detection>();

            //when a new set is added at the server, calls the add function with appropriate information
            Detections.Add(new Detection
            {
                TimeStamp = "12.09.2023.12.01",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/VW_K%C3%A4fer_Baujahr_1966.jpg/1920px-VW_K%C3%A4fer_Baujahr_1966.jpg",
                DetectionType = "Car"
            });
            Detections.Add(new Detection
            {
                TimeStamp = "8.4.2024.6.58",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Man_of_the_woods.JPG/1024px-Man_of_the_woods.JPG",
                DetectionType = "Animal"
            });
            Detections.Add(new Detection
            {
                TimeStamp = "2.3.4000.4.50",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Karl_Marx_001.jpg/800px-Karl_Marx_001.jpg",
                DetectionType = "Human"
            });
            Detections.Add(new Detection
            {
                TimeStamp = "123123123",
                ImageUrl = "https://tfwiki.net/mediawiki/images2/8/85/WarWithin1_ironhide_cyb_alt_mode.jpg",
                DetectionType = "Car"
            });
            Detections.Add(new Detection
            {
                TimeStamp = "111111",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c5/Beast_Wars_title_logo.jpg",
                DetectionType = "Car"
            });
            Detections.Add(new Detection
            {
                TimeStamp = "232323232323",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Karl_Marx_001.jpg/800px-Karl_Marx_001.jpg",
                DetectionType = "Human"
            });
            Detections.Add(new Detection
            {
                TimeStamp = "3434343434",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/c/c5/Beast_Wars_title_logo.jpg",
                DetectionType = "Car"
            });
            Detections.Add(new Detection
            {
                TimeStamp = "23424234234234",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Karl_Marx_001.jpg/800px-Karl_Marx_001.jpg",
                DetectionType = "Human"
            });
        }
    }
}