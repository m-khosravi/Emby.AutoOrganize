﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Emby.AutoOrganizeMD.Core
{
    public class OrganizationException : Exception
    {
        public OrganizationException()
        {
            
        }

        public OrganizationException(string msg) : base(msg)
        {

        }

    }
}
