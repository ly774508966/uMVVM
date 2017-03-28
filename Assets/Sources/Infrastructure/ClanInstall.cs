﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Sources.ViewModels;
using Assets.Sources.Views;
using UnityEngine;

namespace Assets.Sources.Infrastructure
{
    public class ClanInstall:MonoBehaviour
    {
        public ClanView clanView;
        void Start()
        {
            //绑定上下文
            clanView.BindingContext = new ClanViewModel();
            //立刻显示
            clanView.Reveal();
        }
    }
}
