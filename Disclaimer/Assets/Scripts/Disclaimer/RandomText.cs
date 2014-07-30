//using UnityEditor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Timers;
using UnityEngine;

public class RandomText : MonoBehaviour {
	public static float randomTime = 3;
	private float timer = randomTime;
	//private Timer timer;

	public bool isRandom;

	public TextMesh txtFollow;
	public TextMesh txtFollowLeft;
	public TextMesh txtFollowRight;
	public TextMesh txtRates;
	public TextMesh txtBy;
	public TextMesh txtRatesPhrases;
	public TextMesh txtIQ;
	public TextMesh txtRatesBig;
	public TextMesh txtRatesBigLong;

	public TextMesh txtFollow_fr;
	public TextMesh txtFollowLeft_fr;
	public TextMesh txtFollowRight_fr;
	public TextMesh txtRates_fr;
	public TextMesh txtBy_fr;
	public TextMesh txtRatesPhrases_fr;
	public TextMesh txtIQ_fr;
	public TextMesh txtRatesBig_fr;
	public TextMesh txtRatesBigLong_fr;

	public TextMesh txtFollow_cn;
	public TextMesh txtFollowLeft_cn;
	public TextMesh txtFollowRight_cn;
	public TextMesh txtRates_cn;
	public TextMesh txtBy_cn;
	public TextMesh txtRatesPhrases_cn;
	public TextMesh txtIQ_cn;
	public TextMesh txtRatesBig_cn;
	public TextMesh txtRatesBigLong_cn;

	private string follow_phrases;
	private string rates;
	private string by_phrases;
	private string rates_phrases;
	private string IQ_phrases;

	private string follow_phrases_fr;
	private string rates_fr;
	private string by_phrases_fr;
	private string rates_phrases_fr;
	private string IQ_phrases_fr;

	private string follow_phrases_cn;
	private string rates_cn;
	private string by_phrases_cn;

//	private string[] ar_follow_phrases;
//	private string[] ar_rates;
//	private string[] ar_by_phrases;
//	private string[] ar_rates_phrases;
//	private string[] ar_IQ_phrases;
//
//	private string[] ar_follow_phrases_fr;
//	private string[] ar_rates_fr;
//	private string[] ar_by_phrases_fr;
//	private string[] ar_rates_phrases_fr;
//	private string[] ar_IQ_phrases_fr;

	private List<string> ar_follow_phrases;
	private List<string> ar_rates;
	private List<string> ar_by_phrases;
	private List<string> ar_rates_phrases;
	private List<string> ar_IQ_phrases;
	
	private List<string> ar_follow_phrases_fr;
	private List<string> ar_rates_fr;
	private List<string> ar_by_phrases_fr;
	private List<string> ar_rates_phrases_fr;
	private List<string> ar_IQ_phrases_fr;

	private string[] ar_follow_phrases_cn;
	private string[] ar_rates_cn;
	private string[] ar_by_phrases_cn;

	private System.Random rdnNo;

	// Use this for initialization
	void Start () {
		rdnNo = new System.Random (265);

//		timer = new Timer (randomTime * 1000);
//		timer.Elapsed += new ElapsedEventHandler (timer_randomize);
//		timer.Enabled = true;

		follow_phrases = "videos  HAve.film  HAS.book  HAS.program  HAS.activity  HAS.cult  HAS.cultural product  HAS.presentation  HAS.ideology  HAS.lecture  HAS.articles  HAve.process  HAS.preview  HAS.trash  HAS.masterpiece  HAS.distraction  HAS.WEBSITE  HAS.subject  HAS.participatory knot  HAS.report  HAS.station  HAS.papyrus-scroll  HAS.stimulus  HAS.poem  HAS.nonsense  HAS.performance  HAS.incantation  HAS.parable  HAS.hologram  HAS.erotica  HAS.dream  HAS.revelation  HAS.soap-opera  HAS.thesis  HAS.interface  HAS.song  HAS.mashup  HAS.network  HAS.mental-aberration  HAS.reservoir  HAS.tv  HAS.technology  HAS.apparatus  HAS.symbol  HAS.black-hole  HAS.eye-candy  HAS.confession  HAS.membrane  HAS.experience  HAS.investigation  HAS.research  HAS.art  HAS.video-poem  HAS.installation  HAS.ideology  HAS.aesthetic  HAS.critique  HAS.review  HAS.serendipity  HAS.epiphany  HAS.retraction  HAS.culture  HAS.Drug  has.Exhibition  has.Spectacle  has.Law  has.Ceremony  has.Work  has.Achievement  has";
		rates = "tainted,undulant,delirious,fertile,gracious,hungry,morbid,needy,restless,servile,virgin,freak,geek,hacktivist,procedural,durable,illicit,trash,nepotistic,sullen,indifferent,labile,contemporary,carcinogenic,smelly,fickle,coin-operated,implausible,ocular,frantic,sleazy,interrogative,peaceful,shrewish,mystified,quick,ergodic,dodgy,liquified,primed,nonsubmergible,esoteric,venerating,synthetic,tactile,confounded,sizzling,knowledgeable,efficient,meticulous,stoned,violent,personable,heavyhearted,polemical,spaciotemporal,thawed,conservative,intercellular,obsequious,detached,blunt,oscillatory,underfed,religious,idiotic,relational,marvellous,braided,queer,decorative,empathic,fire-resistive,absurd,beautiful,crooked,ingenuous,expert,lumpen,passionless,psychogenic,durable,trite,misanthropic,solid,collaborative,stupid,guarded,avuncular,seditious,homoeostatic,practical,jubilant,subservient,insecure,obscene,emotive,loopy,insipid,pure,drunk,exhausted,kindly,sentimental,bent,waning,live,calm,uncivilized,stodgy,unpretentious,solid,authentic,crushed,depressed,horny,insecure,vigilant,proactive,sweaty";
		by_phrases="BY a derelict coalition of marginal creators.BY THE society for the preservation of internet creativity.BY THE VISUAL-POETRY ASSOCIATION OF CANADA, INC.by the spasming retroactive recidivist branch of yr super-ego.by a small nepotistic cluster of cultural elites.by mob rule.by the committee for the perpetuation of closure.by the society for active negation.by the corporate branch of your identity's core.by the public interest group for security of the psyche.by the integrated anaesthetic lobby group.by the international action party for the decimation of aberrations.By an alliance of revolutionary proprietary robots.By the union of democratic censors.By the progressive party for the abolition of parties.By a concerned group of citizens just like you.By an autocratic process that no one really understands.By a single person somewhere unknown.By an algorithm designed to emulate common-sense.By a desire for integrated technological profit.By the forum for world purity.By the initiative to protect society from self-destruction.By a consensual process that took several decades.By advocates of random methodologies.By people just like you.By the forces that be.By the impotent and reckless judgements of underpaid staffers.by the resilient arrogance of the elastic force of animals.by tender protectionist ideologically challenged primates.by dense knots of ambulant dendrites.by pre-masticated metaphysical reflexes.by the workgroup for the study of evolutionary censorship.by seasonal fluctuations of migratory opinions.by advocacy groups convened in secret within your flesh.by a lottery which is rigged.by the absurd seriousness of voting.By the committee for shuffled meanings.By sifting through spam until it seems sensible.By guesswork and rationalization.By savagely autocratic and obscure tyranny.By the conversion of quantitative measures into social qualities.By the vibrating inevitability of a system that permeates all.By the blood and hormone traffic of bureaucrats.By sophisticated labs dedicated to your personal protection.By an altruistic entity.By abstract thought copulating with physical reality.By a deep-seeded fear of anything new.By the fugitive softness of volcanic forms.By the cooperative for controlled mutations.By the research society for canonical decisions.By a fog that originates in subjectivity.By an emergent process.By blushing assiduously and collecting the colour.By the department for synthetic constraints.By advisers to an anonymous elected official.By logging your ip into a criminal database.By supervising amoebas as data-entry clerks.By marching in the streets against freedom.By establishing certain baseline encrypted criteria.By soaking synapses in pure light at infinite speed.By executives devoted to radical alternatives.By the administrative assistant's part-time non-unionized board.By a mainframe computer that is smarter than you.By bosses who really do care.By universal systems that are unquestionable.By artificial intelligence distributed in the food.By commanding individuals riddled with doubt.By negligence and synchronicity.By the panel for the impeachment of individuality.By a redundant office worker in their spare time.By an automated web-process.By chance operations applied to an irrelevant data-set.By homeless telepathic mystic aliens.By a  government that  has no power.By anarchists who live in the suburbs.By surveillance operatives who read yr email to guess wht u wanted.By tenured children in a sweatshop toilet.By executive order of an obscure by-law.By a random scheme that just happened to work.By intrinsic feature-analysis and stochastic process.By aggregating secret opinions.By packs of alienated intuitions.By smart mobs released into virtual environments.By a dog who has the iq of a genius.By a herd of migratory seals equipped with multi-touch collars.By rogue wishes harvested from government forms.By the alliance for the endorsement of negativity.By the partnership for a contrite public.By the union of all non-unionized censors.By product placements that involve more money than we can mention.By a tribe of incompetent affiliations.By tribunal, in secret, over many years.By the under-privileged matter that makes your body.By amalgamating cliques to critical mass.By the cooperative for the establishment of trivial limits.By a bunch of arbitrary  deflections.By deducting yr net worth from the value of time wasted.By a crowd of unemployed herbalists.By txt mssg referendums.By forged coups and fierce in-house branding.By the concerted efforts of well-intentioned tyrants.By quality-control clinics of hauteur-couture concepts";
		rates_phrases="pigs that cry, people that feed planes, weeping words.dust strobing particles, turbulent knots of numinosity, crushed water.plastic coats, upside down people tap-dancing, humans in bottles.aloe vera lava, maple syrup magma, sandcastle worms, soya storms.HAllucinatory content, ambiguity, no plots, some meat sculpture.arms that hold streams, rivulet ditch paradises, unfinished parables.slouching instincts, surly reservoirs, inflatable phrases.stove-top 3D, tumescent neologisms, itching sounds.lip froth, red-eye spit bubbles, mango mush, vulvas.jubilant jubilant jubilant jubilant jubilant jubilant .one by one by one by one by one by one.to the point of narcisstic black-holes that bloom to become suns.sticky, gluey, grimy, gooey, gui, smoochy, smeary.neurotic enlightenment in tablet form.some conditions apply, other conditions don't.amphetamine quad core gpu accelerated lyricism.not really listening because already somehow preoccupied.served fresh with propogandic fog.scandal fetish hormone trigger morsel gear rogue.osmosis fragile lithe epiphanies.beginning here and continuing into the post-human post-sex era.phone sex drug train cell mute love.crunchy malignancies, psychic torsion, meat in blenders.Combinatorial poetry, generative archives, wistful scenarios.Idiosyncratic perspectives, mute tones, migrant easing functions.Tensile derivatives, rhapsodic theories, experiments that bleed buttons.Ingesting instigates recursion.Cannot be sold in stores, not suitable for sports addicts.Constraint speculations immersed in immediacy.Does not guarantee anything, is not responsible, utterly deterministic.Contraindicated for psychotic conformity.Orally edited anechoic aphorisms.Language slaves should take out implants before entering.Please turn off your cell-phones during the transmission.Remote logins are only permitted for avatars without flesh recourse.Itches irrelevance until it laughs.Ordering this online can lead to prosecution in some states.Drinking the taglines can lead to obedience damage.Facts distort in the presence of this material, data bends.Obscurely advocating a impalpable presence.Tethered spores seeking thresholds.Taste-dependent  HAllucinations.Dense emptiness at levels that provoke vertigo.Anarchic rivulets, gestating melancholia, hierarchy acne.Do not attempt this in your own home.Truncated alientation and recursive epistemologies.Perforation anxiety.Discontinuous continuities.Repetitive variations, may induce viewer passivity.Opaque state-spaces populated by inexorable timers.Implementation naps.twitch ratios may evoke recognitions.Contemplative algorithms.Contingent viewers must report experiences by email.Some reports of wound intake  HAve been verified.Fertile oblivions can damage continuity in some participants.Interactivity is minimal and may cause pain to gamers.Scuffed instincts can prove discomfiting to perfectionists.Dissected pulp may induce autonomic changes.Feels like being led blind by an inexorable truth.May illuminate localized reppresion.Mute impotency and paralysis occasionally occur.After viewing, luminous resonances  HAve been verified sprouting.Moist births, insomniac reveries, ruthless efficiency.Blood muses coated in non-linear narrativity.Things may get inside you due to this.Moderate cruft alert.Billboard pronouncement design style.May contain seeds, cannot be spit out once ingested.Contains fur, bodies and tubes of all kind.Involves protracted destabilization of conclusiveness.May provoke opinion shedding, improves circulation.Doggerel wit with absence abuse.Sensual reification dye.Forged beauty exponentially judging fragments.Chromatic jokes served with video can influence appetite.Puking redundancy  HAs been observed in some sensitive visitors.Not suitable for adults.Verified abyss.Weaning issues occur sporadically in multimedia sensitive locations.Tangent forests provoke observable disequilibrium.Glazed coma-style mutations associated with extensive use.Temporary occlusion of motion.purposefulness concurrent with inappropriate smiling.Robots eat the toes of some viewers";
		IQ_phrases="IQ OVER 120 REQUIRES ACCOMPANYING SEDATIVE OR NARCOTIC.nootropic hydergine nu me-dia.some restrictions apply, others never do.boil off that last piece of brain.intelligent awkward & desperate.sinuous knot of joy.sniper fuel for the fake parade.basted in artificial tenderness.animist prehensile and devoted.secret lust paradigm mechanic.meaningless drivel buffet driven & buffeted by meaning.believably challenging belief challenges.knots of extreme naughtiness.given over to childish joy.rippling network fetish overwear.mob locks.porn phenomena in metaphysical sauce.feel good badness done well.metabolically inclined to impatience.talking pure, measuring cure.tease density.honest dishonesty served raw.predictable disclosure.total control, some violence, fake sex.no microphones or cameras were  HArmed in the making of this serendipity.growling, porousness, trauma, strobe lights.speculative diction, puerile diatribes, exotic normalcy.strumming codecs,clip-art concepts, radical conformity.incantatory excursions of infra-human excess.sedate cushioned eye-candy for post-consumption consumers.wistful youth-begetting imagist fury.serene phenomena, some intellectual content.mass confusion side-effects.Morphing linguists, animist tweens, scale inversions.Explicit non-linearity, damp renders, computational syncopation.Smooth but not redolent tv anti-poems.Nurtures an undivided faith in uncertainty.Provokes an intimate awareness of subliminal unity.Stern erratic dream debris.Insight pheromones capable of provoking inter-brain mating.synthetic life, neglected deaths, portable aphorisms.Distributed and downloadable culture.Awakened heartfelt sincerity with overtones of humility.Miasma rants for a metamorphic era.Unstable bubble snags, aka 'troubles'.Peace tornadoes constructed from modular code and moist data.Vague flexible alphabets.Dancing letters, slow vortices, lush torsion.Serendipity ether.Idiomatic scraps, mild bewilderment, cognitive caulking.Pulse topology psychometrics.media pioneering, sod-hut interfaces.Anabolic surrealism, stability wrinkles, innocent tundra.Soft loops, sardonic wishes, dissected ingestion.Question's metabolism, dense nodes of gentleness.Input excess, talking light, flesh ricochets.Autonomous misnomers, prosthetic illusions, hybrid effects.Crisis misanthropy explorations that lead toward love.Sinuous communication arising from a luminous source.scrutiny residue screen ligature.Dissident mind-wash for a distributed generation.Excess discourse for an excessive epoch.Meridian juggling, some funny shit, emptiness in an URL. WARNING: SOUR WEB ATHEISM.Prejudice-soluble sub-conscious muzak.Amniotic cities fabricated from  Hallucinations.Generative trivia batch-rendered to custom specs.Tripod bleeding, autobiographical recycling.Anointed modules, opalescent plug-ins, incremental intuitions.Temporal wash points in a dry cycle.Swearing, inappropriate metaphors, home-made costumes.Beat windows, mutilated syntax, fresh numbness.Helix plumbing, involution labyrinths, basic incomprehensibility.Speck executables, inbox excreta, random thoughts.Gutter nuts putting shut splutter stutters.Yapping at society, contagious difference, micro landscapes.Binary analogs, dangling precipices, desiccated oceans.Tentative experiments toward a personal digital poetics.Reverence disclosures gorging on concentrated contradictions.Entrails tautology, mutable logic, sniff toys.Lithe metabolically-enhanced virtual virtuosity.Core root skin ions.Radiant play flares.Voice socket diffusion.What is said here, need never be repeated or forgotten.Unsaid things that think themselves not things.Weak  Hacks of vulnerable circumstances.Ephemeral pop take-in scratches, burly effluence.Acronym jock-straps, crush conversions, flock gates.message actuated conduit networks";

		follow_phrases_fr = "les vidéos SUIVANTS SONT APPROUVÉS.le film SUIVANT est APPROUVÉ.Le livre SUIVANT est APPROUVÉ.le programme SUIVANT est APPROUVÉ.l' activité SUIVANTe est APPROUVÉe.le culte SUIVANT est APPROUVÉ.le produit culturel SUIVANT est APPROUVÉ.la présentation SUIVANTe est APPROUVÉe.l' idéologie  SUIVANTe est APPROUVÉe.La conférence SUIVANTe est APPROUVÉe.Les articles suivants sont approuvés.Le processus SUIVANT est APPROUVÉ.l' aperçu SUIVANT est APPROUVÉ.la poubelle SUIVANTe est APPROUVÉe.le chef SUIVANT est APPROUVÉ.La distraction SUIVANTe est APPROUVÉe.le SITE-INTERNET SUIVANT est APPROUVÉ.le sujet SUIVANT est APPROUVÉ.le noeud-participatif SUIVANT est APPROUVÉ.le rapport SUIVANT est APPROUVÉ.La station  SUIVANTe est APPROUVÉe.le parchemin SUIVANT est APPROUVÉ.le stimulus SUIVANT est APPROUVÉ.le poème SUIVANT est APPROUVÉ.le non-sens SUIVANT est APPROUVÉ.La performance SUIVANTe est APPROUVÉe.l' incantation SUIVANTe est APPROUVÉe.La parabole  SUIVANTe est APPROUVÉe.l' hologramme SUIVANT est APPROUVÉ.l' érotisme SUIVANT est APPROUVÉ.le rêve SUIVANT est APPROUVÉ.La Révélation SUIVANTe est APPROUVÉe.Le soap-opera SUIVANT est APPROUVÉ.La thèse SUIVANTe est APPROUVÉe.l' Interface SUIVANTe est APPROUVÉe.La chanson SUIVANTe est APPROUVÉe.le mashup SUIVANT est APPROUVÉ.le réseau SUIVANT est APPROUVÉ.l' aberration-mentale SUIVANTe est APPROUVÉe.le réservoir SUIVANT est APPROUVÉ.La TV SUIVANTe est APPROUVÉe.La technologie SUIVANTe est APPROUVÉe.l' appareil SUIVANT est APPROUVÉ.Le Symbole SUIVANT est APPROUVÉ.le trou noir SUIVANT est APPROUVÉ.Le eye-candy SUIVANT est APPROUVÉ.La confession SUIVANTe est APPROUVÉe.La membrane  SUIVANTe est APPROUVÉe.l' expérience  SUIVANTe est APPROUVÉe.l' enquête SUIVANTe est APPROUVÉe.La recherche SUIVANTe est APPROUVÉe.l' art SUIVANT est APPROUVÉ.le vidéo-poème SUIVANT est APPROUVÉ.l' installation SUIVANTe est APPROUVÉe.l' idéologie SUIVANTe est APPROUVÉe.l' esthétique SUIVANTe est APPROUVÉe.La critique SUIVANTe est APPROUVÉe.l' avis suivant est approuvé.l' heureux hasard est approuvé.l' Epiphanie SUIVANTe est APPROUVÉe.La rétraction SUIVANTe est APPROUVÉe.La culture SUIVANTe est APPROUVÉe.La Drogue SUIVANTe est APPROUVÉe.l' Exposition SUIVANTe est APPROUVÉe.Le Spectacle SUIVANT est APPROUVÉ.la Loi SUIVANTe est APPROUVÉe.La Cérémonie  SUIVANTe est APPROUVÉe.les travaux SUIVANTs sont APPROUVÉs.la réalisation SUIVANTe est APPROUVÉe";
		rates_fr = "Contaminées,ondulantes,délirantes,fertiles,gracieuses,affamées,morbides,nécessiteuses,inquiètes,serviles,vierges,freak,Geek,hacktivistes,procédures,durables,illicites,déjectées,népotistes,maussades,indifférentes,labiales,contemporaines,cancérigènes,malodorantes,indécises,prépayées,invraisemblables,oculaires,frénétiques,louches,interrogatives,pacifiques,acariâtres,mystifiées,rapides,ergodiques,douteuses,liquéfiées,amorcées,nonsubmergibles,ésotériques,vénérées,synthétiques,tactiles,confondues,grésillantes,compétentes,efficaces ,méticuleuses,dénoyautées,violentes,plaisantes,au cœur gros,polémiques,spatiales,décongelées,conservatrices,intercellulaires,obséquieuses,détachées,brusques,oscillantes,sous-alimentées,religieuses,idiotes,relationnelles,merveilleuses,tressées,queer,décoratives,empathiques,résistantes au feu ,absurdes,belles,tordues,ingénues,expertes,grumeleuses,sans passion,psychogènes,durables,banales,misanthropes,solides,collaboratives,stupides,surveillées,avunculaires,séditieuses,homéostatiques,pratiques,jubilatoires,subalternes,insécures,obscènes,émotives,bouclées,insipides,pures,ivres,fatiguées,aimables,sentimentales,courbées,déclinées,vivantes,calmes,non civilisées,indigestes,sans-prétention,solides,authentiques,écrasées,déprimées,horny,insécures,vigilantes,proactives,en sueur";
		by_phrases_fr = "Par une coalition abandonnée de créateurs marginaux.Par la Société pour la préservation de la créativité sur Internet.Par l' ASSOCIATION des poÈtes visuels du CANADA, INC.par la branche récidiviste rétroactive de votre super-ego.par un petit groupe népotiste des élites culturelles.par la loi du peuple.par le comité pour la perpétuation de la fermeture.par la société pour la négation active.par la Direction générale de la base de votre identité.par le groupement d'intérêt public pour la sécurité de la psyché.par le groupe de pression d'anesthésie intégrée.par le parti international d'action pour la décimation des aberrations.Par une alliance révolutionnaire de propriétaires robots.Par l'union de la censure démocratique.Par le Parti progressiste pour la suppression des partis.Par un groupe de citoyens concernés, tout comme vous.Par un processus autocratique que personne ne comprend vraiment.Par une seule personne quelque part inconnue.Par un algorithme conçu pour émuler le sens commun.Par un désir de profit technologique intégrée.Par le Forum pour la pureté du monde.Par l'initiative de protéger la société contre l'auto-destruction.Par un processus consensuel qui a eu plusieurs décennies.Par les partisans des méthodes aléatoires.Par des gens comme vous.Par les forces en place.Par les jugements  téméraires et impotents d'agents sous-payés.par l'arrogance résiliente de la force élastique des animaux.Par des protectionnistes vulnérables, primates idéologiquement contestés.par des nœuds denses de dendrites ambulatoires.Par réflexes métaphysiques pré-mastiqués.par le groupe d'étude de l'évolution de la censure.par les fluctuations saisonnières des opinions migratoires.par les groupes de défense convoqués en secret au sein de votre chair.par une loterie  truquée.par la gravité absurde du vote.Par le comité de significations mélangées.En passant le spam au tamis jusqu'à ce qu'il semble raisonnable.Par tâtonnement et rationalisation.Par tyrannie sauvage et autocratisme obscure.Par la conversion de mesures quantitatives en qualités sociales.Par la fatalité d'un système de vibration qui imprègne tout.Par le sang et le traffic d'hormones de bureaucrates.Par des laboratoires sophistiqués dédiés à votre protection personnelle.Par une entité altruiste.Par la pensée abstraite s'accouplant avec la réalité physique.Par une peur profonde de toutes nouveautés.Par la douceur des formes fugitives volcaniques.Par la coopérative pour les mutations contrôlées.Par la la Société de recherche pour les décisions canoniques.Par un brouillard né de la subjectivité.Par un processus émergent.En rougissant assidûment et accumulant la couleur.Par le Département des contraintes synthétiques.Par un fonctionnaire anonymement élu.En connectant votre IP dans une base de données criminelles.En supervisant les amibes comme commis d'entrée de données.En marchant dans les rues contre la liberté.En établissant des critères de références cryptées.En trempant des synapses dans la pure lumière à une vitesse infinie.Par les dirigeants consacrés à des alternatives radicales.Par l'adjoint administratif à temps partiel du conseil non syndiqué.Par un ordinateur central qui est plus intelligent que vous.Par des patrons qui pensent à vous.Par des systèmes universels qui sont incontestables.Par l'intelligence artificielle distribuée dans les aliments.Par des personnes puissantes criblées de doute.Par la négligence et la synchronicité.Par le Comité pour la destitution de l'individualité.Par des employés de bureau superflus dans leur temps libre.En vertu d'un processus automatisé en ligne.Par Opérations aléatoires appliquées à un ensemble de données non pertinentes.Par extra terrestres errants télépathes et mystiques.Par un gouvernement qui n'a aucun pouvoir.Par des anarchistes qui vivent dans les banlieues.Par des agents de surveillance qui ont lu vos e-mail pour deviner ce que vous vouliez.Par les enfants titulaires dans les toilettes d'exploitation.Par ordonnance d'un règlement obscur.Par un complot aléatoire qui vient d'avoir lieu au travail.En fonction d'analyse intrinsèque et processus stochastiques.En agrégeant des opinions secretes.Par clans d'intuitions aliénées.Par des foules intelligentes libérées dans les environnements virtuels.Par un chien qui a le QI d'un génie.Par un troupeau de phoques migrateurs équipés de colliers multi-touches.Par  souhaits coquins récoltés à partir de formulaires du gouvernement.Par l'Alliance pour l'approbation de la négativité.Par le Partenariat pour un public pénitent.Par l'union de tous les censeurs non-syndiqués .Par le placement d'un produit qui implique plus d'argent que nous pouvons mentionner.Par une tribu d'affiliations incompétentes.Par un secret tribunal, pendant de nombreuses années.Par la matière sous-privilégiée qui compose votre corps.En fusionnant les cliques de la masse critique.Par la coopérative qui fixe des limites triviales.Par un détournement arbitraire.En déduisant la valeur nette de la valeur du temps perdu.Par une foule de chômeurs herboristes.Par référendums messages textos.Par coups d'états forgés et le brand marketing féroce.Par les efforts concertés de tyrans bien intentionnés.Par les cliniques de contrôle de qualité de concepts haute-couture";		
		rates_phrases_fr = "porcs qui crient, les gens qui alimentent les avions, des mots qui pleurent.les particules de poussière stroboscopique, noeuds de numinosité turbulente, l'eau écrasée.manteaux en plastique, les gens dansant les claquettes, la tête en bas, les êtres humains dans des bouteilles.de la lave d’aloe vera, le magma de sirop d'érable, les vers de châteaux de sable, les tempêtes de soja.Le contenu hallucinatoire, l'ambiguïté, aucun déroulement, des parcelles de sculpture de viande.Des bras qui tiennent les cours d'eau, paradis au ruisseaux narcissiques, paraboles inachevées.Des instincts affalés, des réservoirs hargneux, des phrases gonflables.Des cuisinières 3D, néologismes tumescentes, Des sons qui démangent.les lèvres mousseuses, des yeux rouges qui crachent des bulles, de la purée de mangue, vulves.jubilant jubilant jubilation liesse liesse liesse.un par un par un par un par un par un.De narcissiques trous noirs qui fleurissent à en devenir des soleils.collant, gluant, sale, visqueux, poisseux,  âcre, pâteux.Illumination névrotique sous forme de comprimés.Certaines conditions s'appliquent, les autres conditions ne s’appliquent pas.amphétamine à de base lyrisme accéléré.pas vraiment à l'écoute parce que déjà en quelque sorte préoccupé.Servir frais avec de la propagande brumeuse.(fetish hormone scandale déclenchement engins voyous morceau.)? épiphanies osmose souple fragile.débute ici et continue dans l'ère post-humain post-sexe.Cellulaires, trains, sexe, drogues,amour muet.tumeurs croquantes, torsion psychique,  viande broyées dans les mélangeurs.la poésie combinatoire, archives qui génèrent les scénarios mélancoliques.perspectives idiosyncrasiques, tons muets, les fonctions assouplissantes qui migrent.dérivés à la traction, les théories rhapsodiques, des expérimentations qui saignent des boutons.L'ingestion provoque la récursivité.Ne peut être vendu dans les magasins, ne convient pas pour les accros du sport.Speculations Contraintes plongées dans l'immédiateté.Ne garantit rien, n'est pas responsable, totalement déterministe.Contre-indiqué pour la conformité psychotique.Oralement édité par aphorismes muets.les esclaves de la Langue devraient prendre des implants avant d'entrer.S'il vous plaît éteindre votre téléphones cellulaires au cours de la transmission.Les Connexions à distance ne sont autorisées que pour les avatars, sans recours chair.Chatouille l’irréverance jusqu'à ce qu'il rit.Commande en ligne de ce produit peut entraîner des poursuites dans certains États.De boire les étiquettes peut entraîner des dommages à l’ obéissance.Les Faits sont faussés par la présence de ce materiel, les données se penchent.préconise une presence Obscure et impalpable.des spores captifs qui recherchent des seuils.Hallucinations qui créent une dépendance au niveau des papilles gustatives.Des vides denses qui provoquent le vertige.ruisseaux anarchiques, gestation mélancolique acné hiérarchique.Ne tentez pas ceci dans votre propre maison.alienation tronquée et épistémologies récursives.Anxiété de la Perforation.continuités discontinues.variations répétitives, peuvent induire la passivité du spectateur.Etat Opaque des espaces habités par des minuteries inexorables.PAN mise en œuvre.Secousses de ratios peuvent évoquer des  reconnaissances.algorithmes contemplatifs.téléspectateurs contingents doivent présenter un rapport par e-mail.Certains rapports de l'ingestion de plaies ont été vérifiées.Les fertiles oublis peuvent endommager la continuité chez certains participants.L'interactivité  minime  peut causer des douleurs aux joueurs.Instincts épidermés peuvent s'avérer troublants pour les perfectionnistes.La pâte disséquée peut induire des changements autonomes.On peut se sentir entraîné par une aveugle inexorable vérité.Localise la répression.L'impuissance et la paralysie  muettes surviennent parfois.Après le visionnement,il a été vérifié que les résonances lumineuses sont en germination.Naissance humides, rêveries insomniaques, Efficacité impitoyable.Blood muses sanguinaires enrobées de narrativité non-linéaire.Les choses risquent pénétrer à l'intérieur vous.Alerte; embrouillement modéré.Affichage style design prononcé.Peut contenir des graines, ne peuvent pas être recrachés une fois ingérés.Contient de la fourrure, des organismes et des tubes de toutes sortes.Implique une déstabilisation prolongée de force probante.Peut provoquer une effusion d'opinions, améliore la circulation.Esprit qui abuse de l'absence.Colorant de réification sensuelle.Beauté forgée de jugements exponentiels.Blagues Chromatiques servies avec la vidéo peuvent influencer l'appétit.Le vomissement redondant a été observé chez certains visiteurs sensibles.Ne convient pas pour les adultes.Abîme vérifié.problèmes de sevrage se produisent sporadiquement dans des endroits  de multimédia sensibles.forêts Tangents provoquent un déséquilibre observable.A l'utilisation extensive certaines mutations émaillées de style ont pu être observés.Occlusion temporaire du mouvement.Détermination simultanée de sourire inapproprié.Robots peuvent manger les orteils de certains téléspectateurs";
		IQ_phrases_fr = "QI plus de 120 doivent être accompagnés par un sédatif ou narcotique. Hydergine nootropique media.Certaines restrictions s'appliquent, d'autres jamais.faire bouillir ce dernier morceau de cerveau.intelligent et maladroit désespéré.noeud sinueux de joie.sniper de carburant pour le faux défilé.arrosée de tendresse artificielle.préhensiles animistes et dévoués.Méchanismes secrets du paradigme de la luxure.Buffet de non sens.Croyances défiées.Des noeuds de malice extrême.consacrés à la joie enfantine.ondulation-vêtements réseau  fetish. Embouteillages de foules.phénomènes porno à la sauce métaphysique.Se sentir bien dans la méchanceté bien faite.métaboliquement inclinés à l'impatience.parler purement de la mesure de  guérison.Dense séduction taquine. Honnêteté malhonnête servie crue.Divulgation prévisible.Contrôle total, une certaine violence, le faux sexe.Aucun microphone ou caméra a été blessé dans la réalisation de ce heureux hasard .La porosité des traumatismes stroboscopiques.diction spéculative, diatribes puériles et de la normalité exotique.strumming codecs, concepts clip-art, de la conformité radicale.excursions incantatoires des excès infra-humains.Bonbons calmants pour les consommateurs post-consommation.La fureur mélancolique de l”engendrement de la jeunesse.phénomènes sereins, un peu de contenu intellectuel.masse confuse des effets secondaires.Transmutation des linguistes, Interpolations animistes a échelles inversées.Non-linéarité explicite a rendement humide, syncopes de calcul.Lisse, mais ne respire anti tv-poèmes.Nourrit une foi inébranlable dans l'incertitude.Provoque une prise de conscience intime de l'unité subliminale.Débris erratiques de rêves séveres.Phéromones capables de provoquer l'accouplement inter-encéphalique.vie synthétique, décès  négligé, aphorismes portables.Cultures téléchargeables.Coeur sincère éveillé avec des accents d'humilité.Rouspètage dans une ère métamorphique.Chicots de bulles instables, alias «troubles».tornades de paix construites à partir du code modulaire et des données humides.Alphabets vagues et flexibles.lettres qui  dansent, les tourbillons lents, torsion luxuriante.Le hasardde l' éther.déchets idiomatiques, stupeur légère, calfeutrage cognitive. Pouls psychométrique topologique.médias de pionnier, interface maison de papier.surréaliste anabolisantes, la stabilité des rides, la toundra innocente.boucles souples, souhaits sardoniques, ingestion disséquée.Question de métabolisme, les nœuds denses de douceur.excès d'entrée, en parlant de lumière ricochets chair.misnomères autonomes, les illusions de prothèse, effets hybrides.Crises de misanthropie qui mènent  a l'amour.Communication sinueuse découlant d'une source lumineuse.Ecran ligaturé qui contrôle les résidus.Esprit de lavage pour une production décentralisée.discours excessifs d'une époque excessive.jongler avec les meridiens, de la drôle de merde, le vide dans une URL.AVERTISSEMENT: l'athéisme dans le WEB amère. Muzak soluble et subconsciente.Villes amniotique fabriquées à partir d'hallucinations.Information générique pour spécifications personnalisées.Saignements de trépied, le recyclage autobiographique.modules bénis, prises opalescentes des intuitions supplémentaires.points de lavage dans un cycle de séchage.Prestations de blasphèmes, les métaphores inadéquates, costumes faits maison.Windows Beat, syntaxe mutilée de l'engourdissement frais.Labyrinthes d' involution, incompréhensibilité de base.Poussières d'éxécution, excréments boîte de réception, des pensées aléatoires.noix de gouttières bégaient et crépitent.Japper une différence contagieuse dans les paysages micro.analogues binaires, de précipices qui ne tiennent qu'a un fil, des océans desséchés.tâtonnements vers une poétique personnelle numérique.divulgations Révérencielles qui se gavent de contradictions concentrées.Entrailles tautologiques, la logique en mutation de jouets a renifler.Virtuosité souple métaboliquement améliorée.Ions peau racine.Jeux de fusées Radieuse.diffusion des prises de voix.Ce qui est dit ici, ne peut être ni répété ni oublié.les non-dits qui se pensent.Hacks fait de la vulnérabilité.Ephémère pop d'affluence tordue.Un jock-strap d'acronymes, conversions écrasées, portes pour le troupeau.message actionné par les réseaux de conduits";

		follow_phrases_cn = "視頻有.電影了.本書了.程序了.活性.怎麼了.你累了.邪教組織.文化產品了.介紹了.意識形態.演講了.文章都.過程了.預覽了.垃圾桶了.代表作有.分心了.網站上有.主題了.參與結了.報告.車站了.紙莎草卷動了.刺激了.首詩了.廢話了.表現.咒語了.比喻了.全息圖，情色了.夢想.啟示了.肥皂劇了.論文了.界面了.首歌.混搭了.網絡了.精神，像差.水庫了.電視擁有.技術有.設備具有.符號了.黑洞了.眼糖果了.表白了.膜具有.經驗.調查.研究了.藝術了.視頻首詩.安裝了.意識形態，審美了.批判了.檢討.運氣了.頓悟了.回縮了.文化.藥物了.展覽了.眼鏡了.法律有.儀式了.工作了.成就了";
		rates_cn = "污點,波狀,神誌不清,肥沃,親切,餓了,病態,有需要的,坐立不安,奴性,處女,怪胎,怪胎,黑客行動主義,程序,經久耐用,非法,垃圾桶,裙帶關係,慍怒,無動於衷,不穩定,當代,致癌性,臭,善變,投幣式,難以置信,眼部,瘋狂,單薄,疑問句,和平,潑辣,迷惑,快,遍歷,狡猾,液化,催芽, 非潛水 ,深奧,尊老,合成,觸覺,羞愧,炒熱,知識淵博,高效,一絲不苟,砸死,猛烈,風度翩翩,憂心忡忡,論戰, 時空 ,解凍,保守,間,低三下四,分離,鈍,振盪,吃不飽,宗教,白痴,關係,奇妙,編織,奇怪的,裝飾,移情,耐火,荒謬的,美麗,歪,天真,專家,流氓,沒有激情的,心,經久耐用,陳腐,厭世,固體,協作,愚蠢的,守衛,母舅,煽動性,家靜,實用,歡騰,屈從,不安全的,猥褻,情感,多圈,平淡,純淨,喝醉了,耗盡,親切,感傷,彎曲,減弱,住,平靜,不文明,平庸,樸實無華,固體,正宗,粉碎,鬱悶,角質,不安全的,警惕,積極主動,滿身是汗";
		by_phrases_cn = "由邊際創作者的一個廢棄的聯盟.通過互聯網創造的保存社會.由加拿大.詩詞協會會員.由年超我的痙攣追溯累犯分支.由小裙帶集群文化精英.由暴民統治.該委員會為封閉的延續.受到社會的主動否定了你的身份的核心企業分支.公眾利益集團對心靈的安全性.通過集成的麻醉遊說團體.通過對畸變的抽取的國際行動黨，通過革命性的專有機器人聯盟，通過民主檢查員的工會，通過各方的取消進步黨.通過公民就像你的關注組，通過一個專制的過程沒有人真正理解.由一個人在某處不明.通過設計來模擬常識性的算法，通過集成技術利潤的慾望.通過論壇，世界的純潔.通過主動保護社會.免於自我毀滅.由了幾十年協商一致的過程.通過隨機方法的倡導者.由人就像你一樣.由是這樣的勢力.通過少繳員工的無能和魯莽的判斷.動物的彈力的彈性囂張氣焰.通過招標保護主義思想挑戰的.靈長類動物.通過走動樹突稠密節.通過預塑煉形而上學的反射.由工作組進行審查進化的研究.由遷徙的意見季節性波動.通過倡導組織召開秘密你的肉中.通過它操縱彩票.通過投票的荒謬嚴重性.該委員會的洗牌意義.通過垃圾郵件進行篩選，直到它似乎是合理的.通過猜測和合理化.由野蠻專制和暴政晦澀.通過定量措施納入社會素質的轉化.通過一個系統，滲透到所有的振動必然性.官僚的血液和激素的流量.通過專注於你的個人防護複雜的實驗室.由利他實體.通過抽象思維與交配物理現實.通過對新事物的深刻種子的恐懼.由火山形成的逃犯柔軟.通過合作社的控制突變.通過研究社會對規範的決策.由霧起源於主觀性.通過緊急程序.通過紅著臉刻苦鑽研和收集的顏色.由部門合成的約束.由顧問匿名民選官員.通過登錄你的ip為犯罪數據庫.通過監督變形蟲作為數據錄入員.通過在街頭遊行反對自由.通過建立一定的基線加密標準.通過在無限速突觸浸泡在純光.高管致力於激進的替代品.由行政助理的兼職非工會委員會.由電腦主機比你聰明.由老闆誰真正做護理.由是毋庸置疑的通用系統.通過人工智能分佈於食物.由指揮人充滿了疑問.疏忽和同步性.由面板個性的彈劾.通過冗餘的上班族.在他們的業餘時間.由一個自動化的Web進程.一次偶然的機會操作應用到一個不相關的數據集.無家可歸神秘的心靈感應外星人.由一個政府，沒有權力.通過誰住在郊區的無政府主義者.通過誰讀年電子郵件猜測想監視操作工.通過在血汗工廠廁所終身的孩子.由一個不起眼的通過，法律的執行順序.由剛好上班隨機方案.由內在的功能分析和隨機過程.通過聚合秘密的意見.由疏遠直覺的包.通過釋放到虛擬環境中的智能小怪.通過誰擁有了天才的智商狗.通過配備多點觸控衣領遷徙密封件的牛群.由政府表格收穫流氓願望.通過為消極的代言聯盟.通過夥伴關係痛悔公眾.所有非工會檢查員的工會.由涉及更多的錢比我們可以提到產品的展示位置.由不稱職的隸屬關係的一個部落.由仲裁庭.秘密，多年來.由弱勢事，使你的身體.通過合併拉幫結派到臨界質量.通過合作建立的瑣碎限制.由一堆任意變形的.從時間浪費的價值扣除年身家.由一群失業中醫的.由公投.通過偽造政變和激烈的內部品牌.通過善意的暴君的共同努力.由傲慢.時裝理念質量控制診所";

		ar_follow_phrases = new List<string>(follow_phrases.Split ('.'));
		ar_rates = new List<string>(rates.Split (','));
		ar_by_phrases = new List<string>(by_phrases.Split ('.'));
		ar_rates_phrases = new List<string>(rates_phrases.Split ('.'));
		ar_IQ_phrases = new List<string>(IQ_phrases.Split ('.'));

		ar_follow_phrases_fr = new List<string>(follow_phrases_fr.Split ('.'));
		ar_rates_fr = new List<string>(rates_fr.Split (','));
		ar_by_phrases_fr = new List<string>(by_phrases_fr.Split ('.'));
		ar_rates_phrases_fr = new List<string>(rates_phrases_fr.Split ('.'));
		ar_IQ_phrases_fr = new List<string>(IQ_phrases_fr.Split ('.'));

		ar_follow_phrases_cn = follow_phrases_cn.Split ('.');
		ar_rates_cn = rates_cn.Split (',');
		ar_by_phrases_cn = by_phrases_cn.Split ('.');

//		txtFollow = GameObject.Find ("follow_phrases");
//		txtRates = GameObject.Find ("rates");
//		txtBy = GameObject.Find ("by_phrases");
//
//		txtFollow_cn = GameObject.Find ("follow_phrases_cn");
//		txtRates_cn = GameObject.Find ("rates_cn");
//		txtBy_cn = GameObject.Find ("by_phrases_cn");
//
//		txtFollow2 = GameObject.Find ("follow_phrases_2");
//		txtRates2 = GameObject.Find ("rates_2");
//		txtBy2 = GameObject.Find ("by_phrases_2");
//		
//		txtFollow_cn2 = GameObject.Find ("follow_phrases_cn_2");
//		txtRates_cn2 = GameObject.Find ("rates_cn_2");
//		txtBy_cn2 = GameObject.Find ("by_phrases_cn_2");
//
//		txtFollowLeft = GameObject.Find ("follow_left");
//		txtFollowRight = GameObject.Find ("follow_right");

		
	}

	void Update() {
		//auto random
		if (isRandom) {
			StartCoroutine(timer_randomize ());
		}
	}

	IEnumerator timer_randomize() {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			for (int i=0; i<5;i++) {
				random ();
				//Debug.Log("Before Waiting 2 seconds");
				yield return new WaitForSeconds(0.05f);
				//Debug.Log("After Waiting 2 Seconds");
			}
			timer = randomTime;
		}
	}

//	public void timer_randomize(object sender, ElapsedEventArgs e) {
//		random ();
//	}

	public void random() {
		//int rdn = Random.Range(0, ar_follow_phrases.Length);
		int rdn;
		float fx, fy, fz, rx, ry, rz;

		rdn = rdnNo.Next (0, ar_follow_phrases.Count);

		//*** Remove the item from all array ***
		//type here


		//*** Remove the item from all array ***

		string[] tempStrArr = (ar_follow_phrases[rdn]).ToUpper().Split(' ');
		string[] tempStrArr_fr = (ar_follow_phrases_fr[rdn]).ToUpper().Split(' ');
		string[] tempStrArr_cn = (ar_follow_phrases_cn[rdn]).ToUpper().Split(' ');
		 

		/*** Follow Left ***/
		txtFollowLeft.text = "THE FOLLOWING ";
		txtFollowLeft_fr.GetComponent<TextMesh> ().text = tempStrArr_fr [0];
		txtFollowLeft_cn.text = "以下的 ";

		/*** Follow Right ***/
		txtFollowRight.text =  tempStrArr[tempStrArr.Length-1] + " BEEN APPROVED FOR";
		//txtFollowRight_fr.text =  tempStrArr_fr[tempStrArr_fr.Length-1] + " BEEN APPROVED FOR";
		txtFollowRight_fr.text =  tempStrArr_fr[tempStrArr_fr.Length-3] + " " + tempStrArr_fr[tempStrArr_fr.Length-2] + " " + tempStrArr_fr[tempStrArr_fr.Length-1];
		txtFollowRight_cn.text = " 被批准用於";

		/*** Follow ***/
		txtFollow.text = tempStrArr[0];
		txtFollow_fr.text = tempStrArr_fr[1];

		//txtFollow_cn.text = ("以下的" + ar_follow_phrases_cn[rdn] + " 已被批准用於").ToUpper();
		//txtFollow2.text = ("THE FOLLOWING" + ar_follow_phrases[rdn] + " BEEN APPROVED FOR").ToUpper();
		//txtFollow_cn2.text = ("以下的" + ar_follow_phrases_cn[rdn] + " 已被批准用於").ToUpper();



		/*** Follow Left/Right Position ***/
		fx = txtFollow.transform.position.x;
		fy = txtFollow.transform.position.y + 0.6f;
		fz = txtFollow.GetComponent<MeshRenderer>().bounds.size.z/2 + 1f;

		txtFollowLeft.transform.position = new Vector3(fx, fy, -fz);
		txtFollowRight.transform.position = new Vector3(fx, fy, fz);

		fx = txtFollow_fr.transform.position.x;
		fy = txtFollow_fr.transform.position.y + 0.6f;
		fz = txtFollow_fr.GetComponent<MeshRenderer>().bounds.size.z/2 + 1f;
		
		txtFollowLeft_fr.transform.position = new Vector3(fx, fy, -fz);
		txtFollowRight_fr.transform.position = new Vector3(fx, fy, fz);

		fx = txtFollow_cn.transform.position.x;
		fy = txtFollow_cn.transform.position.y + 0.6f;
		fz = txtFollow_cn.GetComponent<MeshRenderer>().bounds.size.z/2 + 1f;

		txtFollowLeft_cn.transform.position = new Vector3(fx, fy, fz);
		txtFollowRight_cn.transform.position = new Vector3(fx, fy, -fz);

		/*** After realign [left] [right], realign [left] [mid] [right] again ***/

//		float tWidth = 0;
//		tWidth += txtFollow_fr.GetComponent<MeshRenderer> ().bounds.size.z;
//		tWidth += txtFollowLeft_fr.GetComponent<MeshRenderer> ().bounds.size.z;
//		tWidth += txtFollowRight_fr.GetComponent<MeshRenderer> ().bounds.size.z;
//
//		fx = txtFollow_fr.transform.position.x;
//		fy = txtFollow_fr.transform.position.y; 
//		fz = txtFollow_fr.transform.position.z - tWidth/2;
//		
//		txtFollow_fr.transform.position = new Vector3(fx, fy, fz);











		/*** Rates ***/
		rdn = rdnNo.Next (0, ar_rates.Count);
		txtRates.text = (ar_rates[rdn] + " AUDIENCES").ToUpper();
		txtRates_fr.text = (ar_rates_fr[rdn] + " AUDIENCES").ToUpper();
		//txtRates_cn.text = (ar_rates_cn[rdn] + " 讀者").ToUpper();
		//txtRates2.text = (ar_rates[rdn] + " AUDIENCES").ToUpper();
		//txtRates_cn2.text = (ar_rates_cn[rdn] + " 讀者").ToUpper();

		/*** By ***/
		rdn = rdnNo.Next (0, ar_by_phrases.Count);
		txtBy.text = (ar_by_phrases[rdn]).ToUpper();
		txtBy_fr.text = (ar_by_phrases_fr[rdn]).ToUpper();
		//txtBy_cn.text = (ar_by_phrases_cn[rdn]).ToUpper();
		//txtBy2.text = (ar_by_phrases[rdn]).ToUpper();
		//txtBy_cn2.text = (ar_by_phrases_cn[rdn]).ToUpper();
		
		/*** Rates_Big ***/
		txtRatesBig.text = (ar_rates[rdn]).ToUpper().Substring(0, 1);
		txtRatesBig_fr.text = (ar_rates_fr[rdn]).ToUpper().Substring(0, 1);


		/*** Rates_BigLong ***/
		txtRatesBigLong.text = (ar_rates[rdn]).ToUpper();
		txtRatesBigLong_fr.text = (ar_rates_fr[rdn]).ToUpper();
		
		
		/*** IQ ***/
		rdn = rdnNo.Next (0, ar_IQ_phrases.Count);
		txtIQ.text = (ar_IQ_phrases[rdn]).ToUpper();
		txtIQ_fr.text = (ar_IQ_phrases_fr[rdn]).ToUpper();
		
		/*** RatesPhrases ***/
		rdn = rdnNo.Next (0, ar_rates_phrases.Count);
		txtRatesPhrases.text = (ar_rates_phrases[rdn]).ToUpper();
		txtRatesPhrases_fr.text = (ar_rates_phrases_fr[rdn]).ToUpper();


	}
}
