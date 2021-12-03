namespace ApplicationCore.User
{
    using System.Collections.Generic;
    using Infrastructure;
    using Project;

    public interface IUser : IEntity
    {
        string FirstName { get; set; }
        string SecondName { get; set; }
        string Password { get; set; }
        string Nickname { get; set; }
        List<MemberProject> Projects { get; set; }
        List<InvitationProject> Invitations { get; set; }
        List<RequestProject> Requests { get; set; }
    }
}