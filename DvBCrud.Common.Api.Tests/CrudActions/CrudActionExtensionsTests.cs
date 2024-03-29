﻿using System;
using DvBCrud.Common.Api.CrudActions;
using FluentAssertions;
using Xunit;

namespace DvBCrud.Common.Api.Tests.CrudActions
{
    public class CrudActionExtensionsTests
    {
        [Fact]
        public void IsActionAllowed_AllowedActionsNotDefined_AllActionsAllowed()
        {
            var crudActions = Array.Empty<CrudAction>();
            crudActions.IsActionAllowed(CrudAction.Create).Should().BeTrue();
            crudActions.IsActionAllowed(CrudAction.Read).Should().BeTrue();
            crudActions.IsActionAllowed(CrudAction.Update).Should().BeTrue();
            crudActions.IsActionAllowed(CrudAction.Delete).Should().BeTrue();
        }

        [Fact]
        public void IsActionAllowed_ReadOnlyActions_OnlyReadAllowed()
        {
            var crudActions = new [] { CrudAction.Read };
            crudActions.IsActionAllowed(CrudAction.Create).Should().BeFalse();
            crudActions.IsActionAllowed(CrudAction.Read).Should().BeTrue();
            crudActions.IsActionAllowed(CrudAction.Update).Should().BeFalse();
            crudActions.IsActionAllowed(CrudAction.Delete).Should().BeFalse();
        }

        [Fact]
        public void IsActionAllowed_NoDelete_OnlyDeleteForbidden()
        {
            var crudActions = new [] { CrudAction.Create, CrudAction.Read, CrudAction.Update };
            crudActions.IsActionAllowed(CrudAction.Create).Should().BeTrue();
            crudActions.IsActionAllowed(CrudAction.Read).Should().BeTrue();
            crudActions.IsActionAllowed(CrudAction.Update).Should().BeTrue();
            crudActions.IsActionAllowed(CrudAction.Delete).Should().BeFalse();
        }
    }
}
