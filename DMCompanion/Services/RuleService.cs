using System.Collections.Generic;
using DMCompanion.Models;
using DMCompanion.Data;
using System.Linq;

namespace DMCompanion.Services{
    public class RuleService{
        private readonly ApplicationDBContext _context;
        public RuleService(ApplicationDBContext context){
            _context = context;
        }
        public void AddRule(Rule rule){
            _context.Rules.Add(rule);
            _context.SaveChanges();
        }
        public List<Rule> SearchRules(string searchTerm){
            return _context.Rules
            .Where(rule => rule.Name.Contains(searchTerm) || rule.Preview.Contains(searchTerm) || rule.Tags.Any(tag => tag.Name.Contains(searchTerm)))
            .ToList();
        } 

        
    }
}