using BrawlLib.SSBB.ResourceNodes;
using BrawlManagerLib;
using DocumentationGenerator.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace DocumentationGenerator.Controllers
{
    public class DefaultController : Controller
    {
        private static string[] RelNames = {
            "[none]",
            "sora_scene",
            "sora_menu_main",
            "sora_menu_tour",
            "sora_menu_qm",
            "sora_menu_edit",
            "sora_menu_collect_viewer",
            "sora_menu_replay",
            "sora_menu_snap_shot",
            "sora_menu_event",
            "sora_menu_sel_char",
            "sora_menu_sel_stage",
            "sora_menu_game_over",
            "sora_menu_intro",
            "sora_menu_friend_list",
            "sora_menu_watch",
            "sora_menu_name",
            "sora_menu_sel_char_access",
            "sora_menu_rule",
            "sora_menu_simple_ending",
            "sora_minigame",
            "sora_menu_time_result",
            "sora_menu_boot",
            "sora_menu_challenger",
            "sora_menu_title",
            "sora_menu_title_sunset",
            "sora_fig_get_demo",
            "sora_melee",
            "sora_adv_menu_name",
            "sora_adv_menu_visual",
            "sora_adv_menu_sel_char",
            "sora_adv_menu_sel_map",
            "sora_adv_menu_difficulty",
            "sora_adv_menu_game_over",
            "sora_adv_menu_result",
            "sora_adv_menu_save_load",
            "sora_adv_menu_seal",
            "sora_adv_menu_ending",
            "sora_adv_menu_telop",
            "sora_adv_menu_save_point",
            "sora_adv_stage",
            "sora_enemy",
            "st_battles",
            "st_battle",
            "st_config",
            "st_final",
            "st_dolpic",
            "st_mansion",
            "st_mariopast",
            "st_kart",
            "st_donkey",
            "st_jungle",
            "st_pirates",
            "st_oldin",
            "st_norfair",
            "st_orpheon",
            "st_crayon",
            "st_halberd",
            "st_starfox",
            "st_stadium",
            "st_tengan",
            "st_fzero",
            "st_ice",
            "st_gw",
            "st_emblem",
            "st_madein",
            "st_earth",
            "st_palutena",
            "st_famicom",
            "st_newpork",
            "st_village",
            "st_metalgear",
            "st_greenhill",
            "st_pictchat",
            "st_plankton",
            "st_dxshrine",
            "st_dxyorster",
            "st_dxgarden",
            "st_dxonett",
            "st_dxgreens",
            "st_dxrcruise",
            "st_dxbigblue",
            "st_dxcorneria",
            "st_dxpstadium",
            "st_dxzebes",
            "st_stageedit",
            "st_otrain",
            "st_heal",
            "st_homerun",
            "st_targetbreak",
            "st_croll",
            "ft_mario",
            "ft_donkey",
            "ft_link",
            "ft_samus",
            "ft_yoshi",
            "ft_kirby",
            "ft_fox",
            "ft_pikachu",
            "ft_luigi",
            "ft_captain",
            "ft_ness",
            "ft_koopa",
            "ft_peach",
            "ft_zelda",
            "ft_iceclimber",
            "ft_marth",
            "ft_gamewatch",
            "ft_falco",
            "ft_ganon",
            "ft_wario",
            "ft_metaknight",
            "ft_pit",
            "ft_pikmin",
            "ft_lucas",
            "ft_diddy",
            "ft_poke",
            "ft_dedede",
            "ft_lucario",
            "ft_ike",
            "ft_robot",
            "ft_toonlink",
            "ft_snake",
            "ft_sonic",
            "ft_purin",
            "ft_wolf",
            "ft_zako",
        };

        // GET: Default
        public ActionResult CEP() {
			return Generate(
				@"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\DocumentationGenerator\classic_expansion_pack.csv",
				@"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\SDRoot\riivolution\classic_expansion_pack\RSBE01.gct",
				NodeFactory.FromFile(null, @"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\SDRoot\riivolution\classic_expansion_pack\system\common5_en.pac").FindChild("sc_selmap_en", false),
				@"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\SDRoot\riivolution\classic_expansion_pack\module",
				NodeFactory.FromFile(null, @"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\SDRoot\riivolution\classic_expansion_pack\info2\info_en.pac"),
				NodeFactory.FromFile(null, @"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\SDRoot\riivolution\classic_expansion_pack\system\common2_en.pac"),
				@"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\SDRoot\riivolution\classic_expansion_pack\sound\strm"
			);
		}

		// GET: Default
		public ActionResult Omega() {
			return Generate(
				@"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\DocumentationGenerator\omega.csv",
				@"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\SDRoot\riivolution\omega\RSBE01.gct",
				NodeFactory.FromFile(null, @"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\SDRoot\riivolution\omega\system\common5_en.pac").FindChild("sc_selmap_en", false),
				@"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\SDRoot\riivolution\omega\module",
				NodeFactory.FromFile(null, @"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\SDRoot\riivolution\omega\info2\info_en.pac"),
				NodeFactory.FromFile(null, @"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\SDRoot\riivolution\omega\system\common2_en.pac"),
				@"C:\Users\admin\Documents\BrawlHacks\classic\9.0s\ClassicExpansionPack\SDRoot\riivolution\omega\sound\strm"
			);
		}

		private ActionResult Generate(string csv, string gctPath, ResourceNode sc_selmap, string relpath, ResourceNode info_pac, ResourceNode common2, string brstmPath) {
            Func<string, List<string>> split = s => {
                List<string> list = new List<string>();
                StringBuilder current = new StringBuilder();
                bool inQuote = false;
                foreach (char c in s) {
                    if (c == '"') {
                        inQuote = !inQuote;
                    } else if (c == ',' && !inQuote) {
                        list.Add(current.ToString());
                        current.Clear();
                    } else {
                        current.Append(c);
                    }
                }
                list.Add(current.ToString());
                return list;
            };

            List<CEPStage> stages = new List<CEPStage>();
            IList<string> firstLine = null;
            foreach (string line in System.IO.File.ReadAllLines(csv, Encoding.UTF8)) {
                if (firstLine == null) {
                    firstLine = split(line);
                } else {
                    CEPStage s = new CEPStage();
                    int i = 0;
                    foreach (string cell in split(line)) {
                        if (cell != "") {
                            var prop = typeof(CEPStage).GetProperty(firstLine[i]);
                            if (prop?.PropertyType == typeof(bool)) {
                                prop.SetValue(s, bool.Parse(cell));
                            } else {
                                prop?.SetValue(s, cell);
                            }
                        }
                        i++;
                    }
                    stages.Add(s);
                }
            }

            byte[] gct = System.IO.File.ReadAllBytes(gctPath);
            var sss = new BrawlManagerLib.CustomSSSCodeset(gct);
			
            foreach (CEPStage s in stages) {
                try {
                    string relname = StageIDMap.RelNameForPac(s.Filename, true);
                    using (var stream = new FileStream(Path.Combine(relpath, relname), FileMode.Open, FileAccess.Read)) {
                        stream.Seek(3, SeekOrigin.Begin);
                        s.ModuleBase = RelNames[stream.ReadByte()];
                    }
                } catch (FileNotFoundException) { }

                if (s.Alternate) continue;
                int iconId = sss.IconForStage(s.Stage.ID);
                TextureContainer tc = new TextureContainer(sc_selmap, iconId);
				if (tc.icon_tex0 != null) {
					using (MemoryStream ms = new MemoryStream()) {
						using (Bitmap b = tc.icon_tex0.GetImage(0)) {
							b.Save(ms, ImageFormat.Png);
							s.PngIcon = ms.ToArray();
						}
					}
				}
            }
			
			MSBinNode info = (MSBinNode)info_pac.FindChild("MiscData[140]", true);
			var common2_titledata = new List<SongNameBar.SongIndexEntry>(0);
			foreach (ResourceNode child in common2.Children) {
				if (child is Common2MiscDataNode) {
					SndBgmTitleDataNode sndBgmTitleData = child.Children.FirstOrDefault() as SndBgmTitleDataNode;
					if (sndBgmTitleData != null) {
						common2_titledata = sndBgmTitleData.Children.Select(n => new SongNameBar.SongIndexEntry() {
							ID = (ushort)((SndBgmTitleEntryNode)n).ID,
							Index = ((SndBgmTitleEntryNode)n).SongTitleIndex
						}).ToList();
						break;
					}
				}
			}

			List<string> brstms = Directory.EnumerateFiles(brstmPath)
				.Select(s => Path.GetFileNameWithoutExtension(s)).ToList();

			var sdsl = new StageDependentSongLoader(gct);
			foreach (CEPStage stage in stages) {
				Song song;
				if (sdsl.TryGetSong(stage.Stage.ID, out song)) {
					stage.SongFilename = song.Filename;
					stage.SongTitle = info._strings[common2_titledata.Where(c => c.ID == song.ID).Select(c => c.Index).First()];
					//brstms.RemoveAll(s => s == song.Filename);
				}
			}

			var expStages = stages.Where(s => s.Filename.Contains("CUSTOM"));
			return View("Index", new MainModel {
				Stages = stages.Except(expStages).Concat(expStages).ToList(),
				Songs = brstms.Select(b => {
					var song = SongIDMap.Songs.SingleOrDefault(s => s.Filename == b);
					return new CEPSong {
						SongFilename = b,
						SongTitle = info._strings[(
							from c in common2_titledata
							where c.ID == song.ID
							select c.Index
						).SingleOrDefault()],
						OriginalSongTitle = b.StartsWith("0000") ? null : song.DefaultName
					};
				})
            });
        }
    }
}