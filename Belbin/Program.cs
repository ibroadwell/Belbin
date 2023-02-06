// See https://aka.ms/new-console-template for more information
Console.WriteLine("Belbin Test");
Console.WriteLine();


string[,] prompts = { { "1. I can be relied upon to see that work that needs to be done is organised",
"2. I pick up slips and omissions that others fail to notice",
"3. I react strongly when meetings look like losing track of the main objective",
"4. I produce original suggestions",
"5. I  analyse  other  people’s  ideas  objectively,  for  both  merits  and failings",
"6. I am keen to find out the latest ideas and developments",
"7. I have an amplitude for organising people",
"8. I am always read to support good suggestions that help to resolve a problem"},
{ "1. I like to have a strong influence on decisions",
"2. I feel in my element where work requires a high degree of attention and concentration",
"3. I am concerned to help colleagues with their problems",
"4. I like to make ciritical discrimination between alternatives",
"5. I tend to have a creative approach to problem solving",
"6. I enjoy reconciling different points of view",
"7. I am more interested in practicalities than new ideas",
"8. I praticularly enjoy exploring different views and techniques"},
{ "1. I keep a watching eye on areas where difficulty may arise",
"2. I explore ideas that may have a wider application than in the immediate task",
"3. I like to weigh up and evaluate a range of suggestions thoroughly before choosing",
"4. I can co-ordinate and use productively other people's abilities and talents",
"5. I maintain a steady systematic approach, whatever the pressures",
"6. I often produce a new approach to a long continuing problem",
"7. I am ready to make my personal views known in a forceful way if necessary",
"8. I am ready to help whenever I can"},
{ "1. I am keen to see there is nothing vague about my task and objectives",
"2. I am not reluctant to emphasis my own point of view in meetings",
"3. I can work with all sorts of people provided that they have got something worthwhile to contribute",
"4. I make a point of following up interesting ideas and/or people",
"5. I can usually find the argument and refute unsound propositions",
"6. I tend to see patterns where others would see items as unconnected",
"7. Being busy gives me real satisfaction",
"8. I have a quiet interest in getting to know people better"},
{ "1. I often find my imagination frustrated by working in a group",
"2. I find my personal skill particularly appropriate in achieving agreement",
"3. My feelings seldom interfere with my judgement",
"4. I strive to build up an effective structure",
"5. I can work with people who vary widely in their personal qualities and outlook",
"6. I feel it is sometimes worth incurring some temporary unpopularity if no is to succeed in getting one's views across in a group",
"7. I usually know someone whos specialist knowledge is particularly apt",
"8. I seem to develop a natural sense of urgency"},
{ "1. I start to look around for possible ideas and openings",
"2. I am concerned to finish and perfect current work before I start",
"3. I approach the problem in a carefully analytical way",
"4. I am able to assert myself to get other people involved if necessary",
"5. I am able to take an independent and innovative look at most situations",
"6. I am happy to take the lead when action is required",
"7. I can respond positively to my colleagues and their initiatives",
"8. I find it hard to give in a jobw here the goals are not clearly defined"},
{ "1. I start to look around for possible ideas and openings",
"2. I am concerned to finish and perfect current work before I start",
"3. I approach the problem in a carefully analytical way",
"4. I am able to assert myself to get other people involved if necessary",
"5. I am able to take an independent and innovative look at most situations",
"6. I am happy to take the lead when action is required",
"7. I can respond positively to my colleagues and their initiatives",
"8. I find it hard to give in a jobw here the goals are not clearly defined"} };

string[] headings = { "Section A: WHEN INVOLVED IN A PROJECT WITH OTHER PEOPLE",
    "Section B: IN SEEKING SATISFACTION THROUGH MY WORK",
    "Section C: WHEN THE TEAM IS TRYING TO SOLVE A PRATICULARLY COMPLEX PROBLEM",
    "Section D: IN CARRYING OUT DAY TO DAY WORK",
    "Section E: IF I AM SUDDENLY GIVEN A DIFFICULT TASK WITH LIMITED TIME AND UNFAMILAR PEOPLE",
    "Section F: WHEN SUDDENLY ASKED TO CONSIDER A NEW PROJECT",
    "Section G: IN CONTRIBUTING TO GROUP PROJECTS IN GENERAL" };


int[,] results = new int[7, 8];
for (int x = 0; x < headings.Length; x++)
{
    Console.WriteLine(headings[x]);
    string[] sectionAResultsString = Scoring(prompts, x).Split(' ');
    for (int i = 0; i < results.GetLength(1); i++)
    {
        results[x, i] = int.Parse(sectionAResultsString[i]);
    }
}


int[] finalResults = new int[8];
int[] finalResultsIndex = new int[8];
int[,] scoringPattern = { { 2, 0, 6, 1, 5, 5, 4 },
                          { 6, 5, 3, 2, 4, 3, 6 },
                          { 3, 4, 5, 5, 0, 4, 5 },
                          { 5, 7, 1, 3, 6, 0, 2 },
                          { 4, 3, 2, 4, 2, 2, 1 },
                          { 0, 6, 4, 0, 3, 7, 0 },
                          { 7, 2, 7, 7, 1, 6, 7 },
                          { 1, 1, 0, 6, 7, 1, 3 } };


Console.Clear();
Console.WriteLine("Belbin Test Results");
Console.WriteLine();
for (int i = 0; i < results.GetLength(1); i++)
{
    for (int j = 0; j < results.GetLength(0); j++)
    {
        finalResults[i] += results[j, scoringPattern[i, j]];

    }
    Console.WriteLine(BelbinType(i) + ": " + finalResults[i]);
}


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
Console.WriteLine("Your primary type is: " + BelbinType(primaryIndex));
Console.WriteLine("Your secondary type is: " + BelbinType(secondaryIndex));

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
        type = "TW - Team Worker";
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
string Scoring(string[,] sectionQuestions, int index)
{
    Console.WriteLine("Choose the 1-3 options that resonate most with you, and assign 10 points in total between those selections");
    for (int j = 0; j < sectionQuestions.GetLength(1); j++)
    {
        Console.WriteLine(sectionQuestions[index, j]);
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
            Console.WriteLine($"What score would you give statement {prompts[c, int.Parse(aSectionArray[c]) - 1]}");
            aSectionScoreString = Console.ReadLine();
            parseSuccess = int.TryParse(aSectionScoreString, out aSectionScore[int.Parse(aSectionArray[c]) - 1]);
            if (parseSuccess == false || aSectionScore[c] > 10 || aSectionScore[c] < 0)
            {
                Console.WriteLine("Please enter digits");
                continue;
            }
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



