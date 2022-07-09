public class Message
{
    public string Name { get; set; }
    public string Content { get; set; }
    public bool Me { get; set; }
    public bool Quest { get; set; }
    public mission.missi Mission { get; set; }
    
    public Message(string name,string content,bool me,bool quest =false,mission.missi mission =mission.missi.not)
    {
        this.Name = name;
        this.Content = content;
        this.Me = me;
        this.Quest = quest;
        this.Mission = mission;
    }
}
