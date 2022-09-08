var isSunny = true;
var isRaining = false;
var isCold = false;
var temp = 75;
if(isSunny && temp < 65)
{
    Console.WriteLine("It's Sunny Dummy!");
        }
else if(isSunny && temp >=65)
{
    Console.WriteLine("it's stinky and sweet");
}
else
{
    Console.WriteLine("It's Not, Its Dark and Scary :(");
}

var errorcode = 404;
switch (errorcode)
{
    case 404:
        Console.WriteLine("Page Not Found");
        break;
    default:
        Console.WriteLine("Unknown error occured");
        break;
}

var moodRating = 0;
var isHappy = false;
var isGlas = true;
if(isHappy)
{
    moodRating = 100;
}
else
{
    moodRating = 0;
}
// same code as the lines above
moodRating = isHappy ? 100 : -100;

moodRating = moodRating + 1;
moodRating += 1;