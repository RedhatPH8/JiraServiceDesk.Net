﻿namespace JiraServiceDesk.Net.Models.Common
{
    public abstract class NamedIdWithLinks : WithLinks
    {
        public abstract class NamedId
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }
    }
}
