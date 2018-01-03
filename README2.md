### LINQ and Lambda exercise

## Disclaimer
Using QuickType, which uses NewtonSoft, we can grab a JSON file, read it in, and create instances of classes.
Be warned, if the JSON used is different, the class structure will change. To update classes, use the QuickType tool online.
To use the QuickType tool, simply insert the json you want to deserialize. It will create classes for the JSON to be read into.

## Dependencies

1. NewtonSoft Json.NET - Documentation for use can be found here https://www.newtonsoft.com/json/help/html/Introduction.htm
2. QuickType - Quicktype uses Json.NET to deserialize and create classes. The tool can be found here https://quicktype.io/

## Functionality

Right now, when you open the program, we'll get the message "QuickType.Neighborhoods". This is our initialization message to make sure our JSON has properly been deserialized.

Once we hit enter to continue, the console will print out every neighborhoods name.
When we hit enter again, we'll use LINQ to get rid of neighborhoods with no name.
When we hit enter again, we'll use a Lambda expression to get rid of duplicates.
Finally, when we hit enter, we'll do all of the previous functionality in one call.

## Upcoming features.

1. Moving code to tests.
2. Moving functionality into callable methods.
