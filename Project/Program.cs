using Project;
try
{
    Person person = new Person();
    ResearchTeam team = new ResearchTeam("Илья мудак", "КБиП", 292, 2);
    for (int i = 0; i < 2; i++)
    {
        Paper paper = new Paper();
        paper.Date = DateTime.Now;
        paper.Info = person;
        paper.Publication = "Хилько";
        team.AddPapers(paper);
    }
    Paper paper1 = new Paper();
    paper1.Date = DateTime.Now;
    paper1.Info = person;
    paper1.Publication = "fghfmhfgrfesgdbnbfsdvbc cfsbc vfdbc";
    team.AddPapers(paper1);
    Paper paper2 = new Paper();
    paper2.Date = DateTime.Now;
    paper2.Info = person;
    paper2.Publication = "zxcvbnm";
    team.AddPapers(paper2);
    team.Show();
}
catch(ArgumentNullException ex)
{
    Console.WriteLine(ex.Message);
}