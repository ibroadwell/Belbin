// See https://aka.ms/new-console-template for more information
Console.WriteLine("Belbin Test");
Console.WriteLine();
string[] sectionA = 
{ "1. I can be relied upon to see that work that needs to be done is organised",
"2. I pick up slips and omissions that others fail to notice",
"3. I react strongly when meetings look like losing track of the main",
"4. I produce original suggestions",
"5. I  analyse  other  people’s  ideas  objectively,  for  both  merits  and failings",
"6. I am keen to find out the latest ideas and developments",
"7. I have an amplitude for organising people",
"8. I am always read to support good suggestions that help to resolve a problem"};
string[] sectionB = 
{ "1. I like to have a strong influence on decisions",
"2. I feel in my element where work requires a high degree of attention and concentration",
"3. I am concerned to help colleagues with their problems",
"4. I like to make ciritical discrimination between alternatives",
"5. I tend to have a creative approach to problem solving",
"6. I enjoy reconciling different points of view",
"7. I am more interested in practicalities than new ideas",
"8. I praticularly enjoy exploring different views and techniques"};
string[] sectionC = 
{ "1. I keep a watching eye on areas where difficulty may arise",
"2. I explore ideas that may have a wider application than in the immediate task",
"3. I like to weigh up and evaluate a range of suggestions thoroughly before choosing",
"4. I can co-ordinate and use productively other people's abilities and talents",
"5. I maintain a steady systematic approach, whatever the pressures",
"6. I often produce a new approach to a long continuing problem",
"7. I am ready to make my personal views known in a forceful way if necessary",
"8. I am ready to help whenever I can"};
string[] sectionD =
{ "1. I am keen to see there is nothing vague about my task and objectives",
"2. I am not reluctant to emphasis my own point of view in meetings",
"3. I can work with all sorts of people provided that they have got something worthwhile to contribute",
"4. I make a point of following up interesting ideas and/or people",
"5. I can usually find the argument and refute unsound propositions",
"6. I tend to see patterns where others would see items as unconnected",
"7. Being busy gives me real satisfaction",
"8. I have a quiet interest in getting to know people better"};
string[] sectionE =
{ "1. I often find my imagination frustrated by working in a group",
"2. I find my personal skill particularly appropriate in achieving agreement",
"3. My feelings seldom interfere with my judgement",
"4. I strive to build up an effective structure",
"5. I can work with people who vary widely in their personal qualities and outlook",
"6. I feel it is sometimes worth incurring some temporary unpopularity if no is to succeed in getting one's views across in a group",
"7. I usually know someone whos specialist knowledge is particularly apt",
"8. I seem to develop a natural sense of urgency"};
string[] sectionF =
{ "1. I start to look around for possible ideas and openings",
"2. I am concerned to finish and perfect current work before I start",
"3. I approach the problem in a carefully analytical way",
"4. I am able to assert myself to get other people involved if necessary",
"5. I am able to take an independent and innovative look at most situations",
"6. I am happy to take the lead when action is required",
"7. I can respond positively to my colleagues and their initiatives",
"8. I find it hard to give in a jobw here the goals are not clearly defined"};
string[] sectionG =
{ "1. I start to look around for possible ideas and openings",
"2. I am concerned to finish and perfect current work before I start",
"3. I approach the problem in a carefully analytical way",
"4. I am able to assert myself to get other people involved if necessary",
"5. I am able to take an independent and innovative look at most situations",
"6. I am happy to take the lead when action is required",
"7. I can respond positively to my colleagues and their initiatives",
"8. I find it hard to give in a jobw here the goals are not clearly defined"};

Console.WriteLine("Section A: WHEN INVOLVED IN A PROJECT WITH OTHER PEOPLE");
string[] sectionAResultsString = Scoring(sectionA).Split(' ');
int[,] results = new int[7, 8];
for (int i = 0; i < results.GetLength(1); i++)
{
    results[0, i] = int.Parse(sectionAResultsString[i]);
}
Console.WriteLine();
Console.WriteLine("Section B: IN SEEKING SATISFACTION THROUGH MY WORK");
string[] sectionBResultsString = Scoring(sectionB).Split(' ');
for (int i = 0; i < results.GetLength(1); i++)
{
    results[1, i] = int.Parse(sectionBResultsString[i]);
}
Console.WriteLine();
Console.WriteLine("Section C: WHEN THE TEAM IS TRYING TO SOLVE A PRATICULARLY COMPLEX PROBLEM");
string[] sectionCResultsString = Scoring(sectionC).Split(' ');
for (int i = 0; i < results.GetLength(1); i++)
{
    results[2, i] = int.Parse(sectionCResultsString[i]);
}
Console.WriteLine();
Console.WriteLine("Section D: IN CARRYING OUT DAY TO DAY WORK");
string[] sectionDResultsString = Scoring(sectionD).Split(' ');
for (int i = 0; i < results.GetLength(1); i++)
{
    results[3, i] = int.Parse(sectionDResultsString[i]);
}
Console.WriteLine();
Console.WriteLine("Section E: IF I AM SUDDENLY GIVEN A DIFFICULT TASK WITH LIMITED TIME AND UNFAMILAR PEOPLE");
string[] sectionEResultsString = Scoring(sectionE).Split(' ');
for (int i = 0; i < results.GetLength(1); i++)
{
    results[4, i] = int.Parse(sectionEResultsString[i]);
}
Console.WriteLine();
Console.WriteLine("Section F: WHEN SUDDENLY ASKED TO CONSIDER A NEW PROJECT");
string[] sectionFResultsString = Scoring(sectionF).Split(' ');
for (int i = 0; i < results.GetLength(1); i++)
{
    results[5, i] = int.Parse(sectionFResultsString[i]);
}
Console.WriteLine();
Console.WriteLine("Section G: IN CONTRIBUTING TO GROUP PROJECTS IN GENERAL");
string[] sectionGResultsString = Scoring(sectionG).Split(' ');
for (int i = 0; i < results.GetLength(1); i++)
{
    results[6, i] = int.Parse(sectionGResultsString[i]);
}

int[] finalResults = new int[8];
int[] finalResultsIndex = new int[8];

//scoring for SH
finalResults[0] = results[0, 2] + results[1, 0] + results[2, 6] + results[3, 1] + results[4, 5] + results[5, 5] + results[6, 4];
finalResultsIndex[0] = 0;
Console.WriteLine("SH: " + finalResults[0]);

//scoring for CO
finalResults[1] = results[0, 6] + results[1, 5] + results[2, 3] + results[3, 2] + results[4, 4] + results[5, 3] + results[6, 6];
finalResultsIndex[1] = 1;
Console.WriteLine("CO: " + finalResults[1]);

//scoring for PL
finalResults[2] = results[0, 3] + results[1, 4] + results[2, 5] + results[3, 5] + results[4, 0] + results[5, 4] + results[6, 5];
finalResultsIndex[2] = 2;
Console.WriteLine("PL: " + finalResults[2]);

//scoring for RI
finalResults[3] = results[0, 5] + results[1, 7] + results[2, 1] + results[3, 3] + results[4, 6] + results[5, 0] + results[6, 2];
finalResultsIndex[3] = 3;
Console.WriteLine("RI: " + finalResults[3]);

//scoring for ME
finalResults[4] = results[0, 4] + results[1, 3] + results[2, 2] + results[3, 4] + results[4, 2] + results[5, 2] + results[6, 1];
finalResultsIndex[4] = 4;
Console.WriteLine("ME: " + finalResults[4]);

//scoring for IMP
finalResults[5] = results[0, 0] + results[1, 6] + results[2, 4] + results[3, 0] + results[4, 3] + results[5, 7] + results[6, 0];
finalResultsIndex[5] = 5;
Console.WriteLine("IMP: " + finalResults[5]);

//scoring for TW
finalResults[6] = results[0, 7] + results[1, 2] + results[2, 7] + results[3, 7] + results[4, 1] + results[5, 6] + results[6, 7];
finalResultsIndex[6] = 6;
Console.WriteLine("TW: " + finalResults[6]);

//scoring for CF
finalResults[7] = results[0, 1] + results[1, 1] + results[2, 0] + results[3, 6] + results[4, 7] + results[5, 1] + results[6, 3];
finalResultsIndex[7] = 7;
Console.WriteLine("CF: " + finalResults[7]);

//sorting

int primaryIndex = 0;
int secondaryIndex = 0;
int primaryMax = 0;
int secondaryMax = 0;

for (int i = 0; i < 8; i++)
{
    if (primaryMax <= finalResults[i])
    {
        primaryMax = finalResults[i];
        primaryIndex = i;
    }
}
for (int i = 0; i < 8; i++)
{
    if (i != primaryIndex)
    {
        if (secondaryMax <= finalResults[i])
        {
            secondaryMax = finalResults[i];
            secondaryIndex = i;
        }
    }
}
Console.WriteLine("Your primary type is: " + BelbinType(finalResultsIndex[primaryIndex]));
Console.WriteLine("Your secondary type is: " + BelbinType(finalResultsIndex[secondaryIndex]));

string BelbinType(int num)
{
    string type = "blue";
    if(num == 0)
    {
        type = "SH - Shaper";
    }
    else if (num == 1)
    {
        type = "CO - Co-ordinator";
    }
    else if (num == 2)
    {
        type = "PL - Plant";
    }
    else if (num == 3)
    {
        type = "RI - Resource Investigator";
    }
    else if (num == 4)
    {
        type = "ME - Monitor Evaluator";
    }
    else if (num == 5)
    {
        type = "IMP - Implementer";
    }
    else if (num == 6)
    {
        type = "TW = Team Worker";
    }
    else if (num == 7)
    {
        type = "CF - Completer-Finisher";
    }
    return type;
}

bool IsDigitsOrSpace(string str)
{
    foreach (char c in str)
    {
        if (c == ' ')
        {
            continue;
        }
        if (c < '0' || c > '9')
        {
            return false;
        }
            
    }

    return true;
}
string Scoring(string[] sectionQuestions)
{
    Console.WriteLine("Choose the 1-3 options that resonate most with you, and assign 10 points in total between those selections");
    for (int j = 0; j < sectionQuestions.Length; j++)
    {
        Console.WriteLine(sectionQuestions[j]);
    }
    string[] aSectionArray = new string[8];
    int[] aSectionScore = { 0, 0, 0, 0, 0, 0, 0, 0 };
    int aSectionMax = 0;
    int aSectionMin = 8;
    bool charTest = true;
    bool emptyTest = false;
    do
    {
        aSectionMax = 0; aSectionMin = 8;
        Console.WriteLine("Which statements do you want to score? (put up to 3 numbers separated by a space)");
        string aSectionInput = Console.ReadLine();
        if (string.IsNullOrEmpty(aSectionInput))
        {
            Console.WriteLine("Please enter some values");
            emptyTest = false;
            continue;
        }
        string[] aSectionInputArray = aSectionInput.Split(' ');

        aSectionArray = aSectionInputArray;
        if (!IsDigitsOrSpace(aSectionInput))
        {
            Console.WriteLine("Please enter only numbers and spaces");
            charTest = false;
            continue;
        }

        for (int i = 0; i < aSectionArray.Length; i++)
        {
            if (int.Parse(aSectionArray[i]) > aSectionMax)
            {
                aSectionMax = int.Parse(aSectionArray[i]);
            }
            if (int.Parse(aSectionArray[i]) <= aSectionMin)
            {
                aSectionMin = int.Parse(aSectionArray[i]);
            }
        }
        if (aSectionArray.Length > 3)
        {
            Console.WriteLine("Please only choose up to 3 statements to score");
        }
        if (aSectionMax > 8 || aSectionMin < 1)
        {
            Console.WriteLine("Please enter statement numbers between 1 and 8 inclusive");
        }
        if (!IsDigitsOrSpace(aSectionInput))
        {
            Console.WriteLine("Please enter only numbers and spaces");
            charTest = false;
        }
    }
    while (aSectionArray.Length > 3 || (aSectionMax > 8 || aSectionMin < 1) || charTest == false || emptyTest == true);
    int aSectionTotal = 0;
    string aSectionScoreString;
    bool parseSuccess = false;

    do
    {
        aSectionTotal = 0;
        for (int c = 0; c < aSectionArray.Length; c++)
        {
            Console.WriteLine($"What score would you give statement {aSectionArray[c]}");
            aSectionScoreString = Console.ReadLine();
            parseSuccess = int.TryParse(aSectionScoreString, out aSectionScore[int.Parse(aSectionArray[c]) - 1]);
            if (parseSuccess == false || aSectionScore[c] > 10 || aSectionScore[c] < 1)
            {
                Console.WriteLine("Please enter digits");
                continue;
            }
            //aSectionScore[int.Parse(aSectionArray[c]) - 1] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < aSectionScore.Length; i++)
        {
            aSectionTotal += aSectionScore[i];
        }
        if (aSectionTotal != 10)
        {
            Console.WriteLine("The scores allocated have to total to 10");
        }
    }
    while (aSectionTotal != 10 || parseSuccess == false);

    return aSectionScore[0] + " " + aSectionScore[1] + " " + aSectionScore[2] + " " + aSectionScore[3] + " " + aSectionScore[4] + " " + aSectionScore[5] + " " + aSectionScore[6] + " " + aSectionScore[7];
}



