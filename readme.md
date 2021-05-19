# KanjiNET
API Wrapper for the kanjiapi.dev API (v1)

This wrapper makes it easy to get the definition of a kanji character and or find words that make use of it
 [kanjiapi.dev](https://kanjiapi.dev/) 

<br>

# Downloads

[NuGet Package](https://www.nuget.org/packages/KanjiNET/)

<br>

# Usage
To get a definition from the Kanji API here's what you should do:

## Create an instance of the KanjiClient
```cs
KanjiClient client = new KanjiClient();
```
Using this client you can start interacting with the API.

## Get a kanji's definition
```cs
KanjiDefinition result = client.GetKanjiDefinition("川").Data;
```

## Get a list of kanji by grade
```cs
String[] results = client.GetKanjiByGrade(Grade.Grade_1).Data;
```

## Get a list of kanji by reading
```cs
KanjiReading result = client.GetKanjiByReading("あり").Data;
```

## Get a list of words that make use of the given kanji
```cs
KanjiWord[] results = client.GetKanjiWords("川").Data;
```

<br><br>

# Information
If anything's not working feel free to create an issue and I'll take a look at it! I'll try to keep this wrapper working if the API updates. 
