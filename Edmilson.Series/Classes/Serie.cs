namespace Edmilson.Series
{
    public class Serie : BaseEntity
    {
        private Gender Gender { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Deleted {get; set;}

        public Serie(int id, Gender gender, string title, string description, int year){
            this.Id = id;
            this.Gender = gender;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Deleted = false;
        }

        public override string ToString() {
            string retorno = "";
            retorno += "Gender: " + this.Gender + Environment.NewLine;
            retorno += "Title: " + this.Title + Environment.NewLine;
            retorno += "Description: " + this.Description + Environment.NewLine;
            retorno += "Launch year: " + this.Year + Environment.NewLine;
            retorno += "Deleted: " + this.Deleted;
            return retorno;
        }

        public string returnTitle() {
            return this.Title;
        }

        public int returnId() {
            return this.Id;
        }

        public void Delete() {
            this.Deleted = true;
        }
    }
}