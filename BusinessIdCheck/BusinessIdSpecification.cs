using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessIdCheck.Interfaces;

namespace BusinessIdCheck
{
    public class BusinessIdSpecification : ISpecification<string>
    {
        private readonly List<string> _reasons;

        public BusinessIdSpecification() => _reasons = new List<string>();

        public IEnumerable<string> ReasonsForDissatisfaction => _reasons;

        public bool IsSatisfiedBy(string id)
        {
            bool isValid = true;
            if (id.Length < 9)
            {
                _reasons.Add("Y-tunnus on liian lyhyt.");
                isValid = false;
            }
            if (id.Length > 9)
            {
                _reasons.Add("Y-tunnus liian pitkä.");
                isValid = false;
            }
            if (!id.Contains("-"))
            {
                _reasons.Add("Y-tunnuksesta puuttuu '-' -merkki.");
                isValid = false;
            }
            if (id.IndexOf("-") != 7)
            {
                _reasons.Add("Y-tunnuksessa '-' -merkki ei ole oikeassa paikkaa.");
                isValid = false;
            }
            return isValid;
        }
    }
}
