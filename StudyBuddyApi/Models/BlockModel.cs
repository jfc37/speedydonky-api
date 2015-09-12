﻿using System;
using System.Collections.Generic;
using Common;
using Newtonsoft.Json;

namespace SpeedyDonkeyApi.Models
{
    public class BlockModel : IEntity
    {
        public BlockModel()
        {
        }

        [JsonConstructor]
        public BlockModel(List<TeacherModel> teachers)
        {
           Teachers = teachers;
        }

        public List<TeacherModel> Teachers { get; set; }
        public List<UserModel> EnroledStudents { get; set; }
        public LevelModel Level { get; set; }
        public List<ClassModel> Classes { get; set; }
        public List<AnnouncementModel> Announcements { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}