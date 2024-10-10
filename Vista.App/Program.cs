using Vista.App.Data; //Import the database classes

var trainerDbContext = new TrainersDbContext();  //Create database context

ListCategories(trainerDbContext);

//Method to list categories from the database
static void ListCategories(TrainersDbContext dbContext)
{
    //Load list of categories form the database
    var categoryList = dbContext.Categories.ToList();
    Console.WriteLine("Category List\n");

    //Display list of categories from the memory object (categoryList)
    foreach(var cat in categoryList){
        Console.WriteLine($"{cat.CategoryCode} {cat.CategoryName}");
    }
    Console.WriteLine();
}