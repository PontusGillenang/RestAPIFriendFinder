# <u>Class User</u>

int UserID  
string UserName  
string UserAdress    
string UserPhoneNumber  
int UserAge  
bool UserIsTeacher  

ICollection<Hobbie> Hobbies
ICollection<Match> Matches

# <u>Class Hobby</u>

int HobbyID  
string HobbyName  
enum HobbyActivationLevel     

# <u>Class City</u>

int CityID  
string CityName   
string CityCountry  
string CityCounty       

# <u>Class Place</u>
 
ICollection<City> Cities
ICollection<Hobby> Hobbies

# Class Match

int MatchID  
User UserOne  
User UserTwo  

# Class Event

Hobby Hobby
User Responsible
City City
