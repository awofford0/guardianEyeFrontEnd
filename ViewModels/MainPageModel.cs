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
                timeStamp = "12.09.2023.12.01",
                imageName = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/96/VW_K%C3%A4fer_Baujahr_1966.jpg/1920px-VW_K%C3%A4fer_Baujahr_1966.jpg",
                category = "Car"
            });
            Detections.Add(new Detection
            {
                timeStamp = "8.4.2024.6.58",
                imageName = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Man_of_the_woods.JPG/1024px-Man_of_the_woods.JPG",
                category = "Animal"
            });
            Detections.Add(new Detection
            {
                timeStamp = "2.3.4000.4.50",
                imageName = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Karl_Marx_001.jpg/800px-Karl_Marx_001.jpg",
                category = "Human"
            });
            Detections.Add(new Detection
            {
                timeStamp = "123123123",
                imageName = "https://tfwiki.net/mediawiki/images2/8/85/WarWithin1_ironhide_cyb_alt_mode.jpg",
                category = "Car"
            });
            Detections.Add(new Detection
            {
                timeStamp = "111111",
                imageName = "https://upload.wikimedia.org/wikipedia/en/c/c5/Beast_Wars_title_logo.jpg",
                category = "Car"
            });
            Detections.Add(new Detection
            {
                timeStamp = "232323232323",
                imageName = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Karl_Marx_001.jpg/800px-Karl_Marx_001.jpg",
                category = "Human"
            });
            Detections.Add(new Detection
            {
                timeStamp = "3434343434",
                imageName = "https://upload.wikimedia.org/wikipedia/en/c/c5/Beast_Wars_title_logo.jpg",
                category = "Car"
            });
            Detections.Add(new Detection
            {
                timeStamp = "23424234234234",
                imageName = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d4/Karl_Marx_001.jpg/800px-Karl_Marx_001.jpg",
                category = "Human"
            });
        }
    }
}