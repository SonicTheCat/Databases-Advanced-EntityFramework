﻿namespace P01_BillsPaymentSystem.Core.Commands
{
    using Attributes;
    using IO.Contracts;
    using P01_BillsPaymentSystem.Data;

    public class UserInfoCommand : Command
    {
        public UserInfoCommand(string[] data, IUnitOfWork unitOfWork, IReader reader, IWriter writer)
            : base(data)
        {
            this.UnitOfWork = unitOfWork;
            this.Reader = reader;
            this.Writer = writer;
        }

        [Inject]
        public IUnitOfWork UnitOfWork { get; set; }

        [Inject]
        public IReader Reader { get; set; }

        [Inject]
        public IWriter Writer { get; set; }

        public override void Execute()
        {
            var id = int.Parse(this.Data[0]);

            this.Writer.WriteLine(OutputMessages.Loading);
            var reuslt = this.UnitOfWork.Users.GetUserAndAllPayments(id);
            this.Writer.WriteLine(reuslt);
        }
    }
}