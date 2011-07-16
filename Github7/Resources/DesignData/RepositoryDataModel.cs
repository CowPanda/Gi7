﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Github7.Model;
using System.Collections.ObjectModel;

namespace Github7.Resources.DesignData
{
    public class RepositoryDataModel
    {
        public Repository Repository { get; set; }

        public ObservableCollection<Push> Commits { get; set; }

        public ObservableCollection<PullRequest> PullRequests { get; set; }

        public RepositoryDataModel()
        {
            Repository = new Repository()
            {
                Owner = new User()
                {
                    Login = "michelsalib"
                },
                Name = "symfony",
                HtmlUrl = "http://github.com/michelsalib/symfony",
                Description = "The Symfony2 PHP framework",
                Watchers = 3,
                Forks = 1,
                Homepage = "symfony.com",
                Parent = new Repository()
                {
                    Owner = new User()
                    {
                        Login = "symfony"
                    },
                    Name = "symfnoy"
                }
            };

            Commits = new ObservableCollection<Push>();
            Commits.Add(new Push()
            {
                Author = new User()
                {
                    Login = "michelsalib",
                    AvatarUrl = "https://secure.gravatar.com/avatar/5c4663b12b9e6d8dc6dcdfbfb3dc1317",
                },
                Commit = new Commit()
                {
                    Message = "message",
                    Author = new Committer()
                    {
                        Date = DateTime.Now,
                    }
                }
            });

            PullRequests = new ObservableCollection<PullRequest>();
            PullRequests.Add(new PullRequest()
            {
                Title = "my pull requets",
                Body = "the description",
                UpdatedAt = DateTime.Now,
                State = "Open",
                User = new User()
                {
                    Login = "michelsalib",
                    AvatarUrl = "https://secure.gravatar.com/avatar/5c4663b12b9e6d8dc6dcdfbfb3dc1317",
                },
            });
        }
    }
}
