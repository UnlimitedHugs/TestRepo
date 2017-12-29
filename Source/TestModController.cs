using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using Harmony;
using HugsLib;
using HugsLib.Utils;
using RimWorld;
using UnityEngine;
using Verse;

namespace TestMod {
	public class TestModController : ModBase {
		public override string ModIdentifier {
			get { return "TestModExt"; }
		}

		public override void Initialize() {
			/*Logger.Trace();
			Logger.Trace("lel", 1, 8, null, this);
			Logger.TraceFormat("{0} > {1}", this, null);
			Tracer.Trace("lel", 1, 8, null, this);
			Tracer.TraceFormat("{0} > {1}", this, null);*/
		}
	}

	/*public class Testy : Mod {
		public Testy(ModContentPack content) : base(content) {
			HarmonyInstance.Create("testy").PatchAll(typeof(Testy).Assembly);
		}
	}

	[HarmonyPatch(typeof(MapGenerator), "GenerateMap")]
	internal class MapGenerator_GenerateMap_Patch {
	}*/

	/*
	[HarmonyPatch(typeof(MapGenerator), "GenerateMap")]
	internal class MapGenerator_GenerateMap_Patch {
		[HarmonyPostfix]
		public static void RememberUsedMapGenerator(Map __result, MapGeneratorDef mapGenerator) {
			Log.Message(__result+" "+mapGenerator.defName);
			//MapRerollController.Instance.ReportUsedMapGenerator(__result, mapGenerator);
		}

		/*[HarmonyPrefix]
		public static void Test(IntVec3 mapSize, MapParent parent, MapGeneratorDef mapGenerator, IEnumerable<GenStepDef> extraGenStepDefs, Action<Map> extraInitBeforeContentGen) {
			Tracer.Trace(mapSize, parent, mapGenerator, extraGenStepDefs, extraInitBeforeContentGen);	
		}

		[HarmonyPostfix]
		public static void Testz(Map __result) {
			Tracer.Trace("map:"+__result);
		}#1#

		/*[HarmonyTranspiler]
		public static IEnumerable<CodeInstruction> Transpile(IEnumerable<CodeInstruction> instructions) {
			foreach (var instruction in instructions) {
				yield return instruction;
			}
		}#1#
	}*/
}