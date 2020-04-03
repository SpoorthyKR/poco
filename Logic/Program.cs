
using Poco;
using System;
using System.Collections.Generic;
using System.Text;

namespace logic

{
    public class poco : Logic<Poco>
    {
        public Poco(IDataRepository<Poco> repository) :
            base(repository)
        { }

        protected override void Verify(Poco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (Poco poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.Major))
                {
                    exceptions.Add(new ValidationException(107, "Blank Major Fix it!!"));
                }
              
            }
            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
        public override void Add(Poco[] pocos)
        {
            Verify(pocos);
            base.Add(pocos);
        }

        public override void Update(Poco[] pocos)
        {
            Verify(pocos);
            base.Update(pocos);
        }
    }
}