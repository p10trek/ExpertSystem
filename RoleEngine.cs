using chen0040.ExpertSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExpertSystem
{
	static class RoleEngine
	{
		public enum Sezon
		{
			Wiosna,
			Lato,
			Jesień,
			Zima
		}
        public enum Pogoda
		{
			Słoneczna,
			Pochmurna,
			Deszczowa,
			Mroźna
        }
        public enum Przeznaczenie
		{
			Spacer,
			Bieg,
			Turystyka,
			Oficjalne
        }
		public enum Płeć
		{
			Kobieta,
			Mężczyzna
		}
		public static RuleInferenceEngine rie = new RuleInferenceEngine();
		public static void getInferenceEngine()
		{
			Console.WriteLine("Start systemu");
			rie.AddRule("Botki", Sezon.Jesień, Pogoda.Deszczowa, Przeznaczenie.Oficjalne, Płeć.Kobieta);
			rie.AddRule("Botki", Sezon.Zima, Pogoda.Deszczowa, Przeznaczenie.Oficjalne, Płeć.Kobieta);
			rie.AddRule("Botki", Sezon.Zima, Pogoda.Mroźna, Przeznaczenie.Oficjalne, Płeć.Kobieta);
			rie.AddRule("Baleriny", Sezon.Lato, Pogoda.Słoneczna, Przeznaczenie.Spacer, Płeć.Kobieta);
			rie.AddRule("Sandały", Sezon.Lato, Pogoda.Słoneczna, Przeznaczenie.Spacer, Płeć.Kobieta);
			rie.AddRule("Czułenka", Sezon.Wiosna, Pogoda.Słoneczna, Przeznaczenie.Oficjalne, Płeć.Kobieta);
			rie.AddRule("Czułenka", Sezon.Lato, Pogoda.Słoneczna, Przeznaczenie.Oficjalne, Płeć.Kobieta);
			rie.AddRule("Trampki", Sezon.Lato, Pogoda.Pochmurna, Przeznaczenie.Spacer, Płeć.Kobieta);
			rie.AddRule("Trampki", Sezon.Lato, Pogoda.Pochmurna, Przeznaczenie.Spacer, Płeć.Kobieta);
			rie.AddRule("Adidasy", Sezon.Lato, Pogoda.Pochmurna, Przeznaczenie.Bieg, Płeć.Kobieta);
			rie.AddRule("Adidasy", Sezon.Lato, Pogoda.Pochmurna, Przeznaczenie.Bieg, Płeć.Mężczyzna);
			rie.AddRule("Kozaki", Sezon.Zima, Pogoda.Mroźna, Przeznaczenie.Spacer, Płeć.Kobieta);
			rie.AddRule("Mokasyny", Sezon.Lato, Pogoda.Słoneczna, Przeznaczenie.Spacer, Płeć.Mężczyzna);
			rie.AddRule("Oksfordy", Sezon.Lato, Pogoda.Pochmurna, Przeznaczenie.Spacer, Płeć.Mężczyzna);
			rie.AddRule("Mokasyny", Sezon.Jesień, Pogoda.Słoneczna, Przeznaczenie.Spacer, Płeć.Mężczyzna);
			rie.AddRule("Oksfordy", Sezon.Jesień, Pogoda.Pochmurna, Przeznaczenie.Spacer, Płeć.Mężczyzna);
			rie.AddRule("Mokasyny", Sezon.Lato, Pogoda.Słoneczna, Przeznaczenie.Oficjalne, Płeć.Mężczyzna);
			rie.AddRule("Oksfordy", Sezon.Lato, Pogoda.Pochmurna, Przeznaczenie.Oficjalne, Płeć.Mężczyzna);
			rie.AddRule("Sneakersy", Sezon.Lato, Pogoda.Pochmurna, Przeznaczenie.Spacer, Płeć.Mężczyzna);
			rie.AddRule("Sneakersy", Sezon.Jesień, Pogoda.Pochmurna, Przeznaczenie.Spacer, Płeć.Mężczyzna);
			rie.AddRule("Sneakersy", Sezon.Wiosna, Pogoda.Pochmurna, Przeznaczenie.Spacer, Płeć.Mężczyzna);
			rie.AddRule("Sneakersy", Sezon.Lato, Pogoda.Słoneczna, Przeznaczenie.Spacer, Płeć.Mężczyzna);
			rie.AddRule("Sneakersy", Sezon.Jesień, Pogoda.Słoneczna, Przeznaczenie.Spacer, Płeć.Mężczyzna);
			rie.AddRule("Sneakersy", Sezon.Wiosna, Pogoda.Słoneczna, Przeznaczenie.Spacer, Płeć.Mężczyzna);
			rie.AddRule("Sneakersy", Sezon.Lato, Pogoda.Pochmurna, Przeznaczenie.Spacer, Płeć.Kobieta);
			rie.AddRule("Sneakersy", Sezon.Jesień, Pogoda.Pochmurna, Przeznaczenie.Spacer, Płeć.Kobieta);
			rie.AddRule("Sneakersy", Sezon.Wiosna, Pogoda.Pochmurna, Przeznaczenie.Spacer, Płeć.Kobieta);
			rie.AddRule("Sneakersy", Sezon.Lato, Pogoda.Słoneczna, Przeznaczenie.Spacer, Płeć.Kobieta);
			rie.AddRule("Sneakersy", Sezon.Jesień, Pogoda.Słoneczna, Przeznaczenie.Spacer, Płeć.Kobieta);
			rie.AddRule("Sneakersy", Sezon.Wiosna, Pogoda.Słoneczna, Przeznaczenie.Spacer, Płeć.Kobieta);
			rie.AddRule("Trapery", Sezon.Zima, Pogoda.Słoneczna, Przeznaczenie.Spacer, Płeć.Mężczyzna);
			rie.AddRule("Trapery", Sezon.Zima, Pogoda.Mroźna, Przeznaczenie.Spacer, Płeć.Mężczyzna);
			rie.AddRule("Trapery", Sezon.Zima, Pogoda.Deszczowa, Przeznaczenie.Spacer, Płeć.Mężczyzna);
			rie.AddRule("Trapery", Sezon.Zima, Pogoda.Pochmurna, Przeznaczenie.Spacer, Płeć.Mężczyzna);
		}
		public static void AddRule(this RuleInferenceEngine ruleInference, string Rule_name, Sezon sezon, Pogoda pogoda, Przeznaczenie przeznaczenie, Płeć plec)
		{
			Rule rule = new Rule(Rule_name);
			rule.AddAntecedent(new IsClause("Sezon",sezon.ToString()));
			rule.AddAntecedent(new IsClause("Pogoda", pogoda.ToString()));
			rule.AddAntecedent(new IsClause("Przeznaczenie", przeznaczenie.ToString()));
			rule.AddAntecedent(new IsClause("Płeć", plec.ToString()));
			rule.setConsequent(new IsClause("Rodzaj Buta", Rule_name));
			ruleInference.AddRule(rule);
		}
		public static void CheckRule(this RuleInferenceEngine ruleInference, Sezon sezon, Pogoda pogoda, Przeznaczenie przeznaczenie, Płeć plec)
        {
			ruleInference.AddFact(new IsClause("Sezon", sezon.ToString()));
			ruleInference.AddFact(new IsClause("Pogoda", pogoda.ToString()));
			ruleInference.AddFact(new IsClause("Przeznaczenie", przeznaczenie.ToString()));
			ruleInference.AddFact(new IsClause("Płeć", plec.ToString()));
			ruleInference.Infer();
		}
	}
}