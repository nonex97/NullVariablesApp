

// null = lack of value

// Haven't asked for the age yet
//int age = 0; // should not be declared as 0, but rather as null, to indicate that the value is not yet assigned. but this one can't be null
int? age = null; // this is a nullable int

//All variables can be nullable
bool? birthday = null;
double? battingAverage = null;
decimal? accountBalance = null;
//string name = null; // string without a ? can be nullable, so we should use string? to indicate that it can be null to be more specific
string? name = null;

// Asked for the age now
age = 0;