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
	private string rates_phrases_cn;
	private string IQ_phrases_cn;

	private string ratings_I;
	private string ratings_A;

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

	private List<string> ar_follow_phrases_cn;
	private List<string> ar_rates_cn;
	private List<string> ar_by_phrases_cn;
	private List<string> ar_rates_phrases_cn;
	private List<string> ar_IQ_phrases_cn;

	private List<String> ar_ratings_I;
	private List<String> ar_ratings_A;


	private System.Random rdnNo;

	// Use this for initialization
	void Start () {
		rdnNo = new System.Random (265);

//		timer = new Timer (randomTime * 1000);
//		timer.Elapsed += new ElapsedEventHandler (timer_randomize);
//		timer.Enabled = true;

		//Default
		addTextField ();

		//english
		follow_phrases = "videos  HAve.film  HAS.book  HAS.program  HAS.activity  HAS.cult  HAS.cultural product  HAS.presentation  HAS.ideology  HAS.lecture  HAS.articles  HAve.process  HAS.preview  HAS.trash  HAS.masterpiece  HAS.distraction  HAS.WEBSITE  HAS.subject  HAS.participatory knot  HAS.report  HAS.station  HAS.papyrus-scroll  HAS.stimulus  HAS.poem  HAS.nonsense  HAS.performance  HAS.incantation  HAS.parable  HAS.hologram  HAS.erotica  HAS.dream  HAS.revelation  HAS.soap-opera  HAS.thesis  HAS.interface  HAS.song  HAS.mashup  HAS.network  HAS.mental-aberration  HAS.reservoir  HAS.tv  HAS.technology  HAS.apparatus  HAS.symbol  HAS.black-hole  HAS.eye-candy  HAS.confession  HAS.membrane  HAS.experience  HAS.investigation  HAS.research  HAS.art  HAS.video-poem  HAS.installation  HAS.ideology  HAS.aesthetic  HAS.critique  HAS.review  HAS.serendipity  HAS.epiphany  HAS.retraction  HAS.culture  HAS.Drug  has.Exhibition  has.Spectacle  has.Law  has.Ceremony  has.Work  has.Achievement  has";
		rates = "tainted,undulant,delirious,fertile,gracious,hungry,morbid,needy,restless,servile,virgin,freak,geek,hacktivist,procedural,durable,illicit,trash,nepotistic,sullen,indifferent,labile,contemporary,carcinogenic,smelly,fickle,coin-operated,implausible,ocular,frantic,sleazy,interrogative,peaceful,shrewish,mystified,quick,ergodic,dodgy,liquified,primed,nonsubmergible,esoteric,venerating,synthetic,tactile,confounded,sizzling,knowledgeable,efficient,meticulous,stoned,violent,personable,heavyhearted,polemical,spaciotemporal,thawed,conservative,intercellular,obsequious,detached,blunt,oscillatory,underfed,religious,idiotic,relational,marvellous,braided,queer,decorative,empathic,fire-resistive,absurd,beautiful,crooked,ingenuous,expert,lumpen,passionless,psychogenic,durable,trite,misanthropic,solid,collaborative,stupid,guarded,avuncular,seditious,homoeostatic,practical,jubilant,subservient,insecure,obscene,emotive,loopy,insipid,pure,drunk,exhausted,kindly,sentimental,bent,waning,live,calm,uncivilized,stodgy,unpretentious,solid,authentic,crushed,depressed,horny,insecure,vigilant,proactive,sweaty";
		by_phrases="BY a derelict coalition of marginal creators.BY THE society for the preservation of internet creativity.BY THE VISUAL-POETRY ASSOCIATION OF CANADA, INC.by the spasming retroactive recidivist branch of yr super-ego.by a small nepotistic cluster of cultural elites.by mob rule.by the committee for the perpetuation of closure.by the society for active negation.by the corporate branch of your identity's core.by the public interest group for security of the psyche.by the integrated anaesthetic lobby group.by the international action party for the decimation of aberrations.By an alliance of revolutionary proprietary robots.By the union of democratic censors.By the progressive party for the abolition of parties.By a concerned group of citizens just like you.By an autocratic process that no one really understands.By a single person somewhere unknown.By an algorithm designed to emulate common-sense.By a desire for integrated technological profit.By the forum for world purity.By the initiative to protect society from self-destruction.By a consensual process that took several decades.By advocates of random methodologies.By people just like you.By the forces that be.By the impotent and reckless judgements of underpaid staffers.by the resilient arrogance of the elastic force of animals.by tender protectionist ideologically challenged primates.by dense knots of ambulant dendrites.by pre-masticated metaphysical reflexes.by the workgroup for the study of evolutionary censorship.by seasonal fluctuations of migratory opinions.by advocacy groups convened in secret within your flesh.by a lottery which is rigged.by the absurd seriousness of voting.By the committee for shuffled meanings.By sifting through spam until it seems sensible.By guesswork and rationalization.By savagely autocratic and obscure tyranny.By the conversion of quantitative measures into social qualities.By the vibrating inevitability of a system that permeates all.By the blood and hormone traffic of bureaucrats.By sophisticated labs dedicated to your personal protection.By an altruistic entity.By abstract thought copulating with physical reality.By a deep-seeded fear of anything new.By the fugitive softness of volcanic forms.By the cooperative for controlled mutations.By the research society for canonical decisions.By a fog that originates in subjectivity.By an emergent process.By blushing assiduously and collecting the colour.By the department for synthetic constraints.By advisers to an anonymous elected official.By logging your ip into a criminal database.By supervising amoebas as data-entry clerks.By marching in the streets against freedom.By establishing certain baseline encrypted criteria.By soaking synapses in pure light at infinite speed.By executives devoted to radical alternatives.By the administrative assistant's part-time non-unionized board.By a mainframe computer that is smarter than you.By bosses who really do care.By universal systems that are unquestionable.By artificial intelligence distributed in the food.By commanding individuals riddled with doubt.By negligence and synchronicity.By the panel for the impeachment of individuality.By a redundant office worker in their spare time.By an automated web-process.By chance operations applied to an irrelevant data-set.By homeless telepathic mystic aliens.By a  government that  has no power.By anarchists who live in the suburbs.By surveillance operatives who read yr email to guess wht u wanted.By tenured children in a sweatshop toilet.By executive order of an obscure by-law.By a random scheme that just happened to work.By intrinsic feature-analysis and stochastic process.By aggregating secret opinions.By packs of alienated intuitions.By smart mobs released into virtual environments.By a dog who has the iq of a genius.By a herd of migratory seals equipped with multi-touch collars.By rogue wishes harvested from government forms.By the alliance for the endorsement of negativity.By the partnership for a contrite public.By the union of all non-unionized censors.By product placements that involve more money than we can mention.By a tribe of incompetent affiliations.By tribunal, in secret, over many years.By the under-privileged matter that makes your body.By amalgamating cliques to critical mass.By the cooperative for the establishment of trivial limits.By a bunch of arbitrary  deflections.By deducting yr net worth from the value of time wasted.By a crowd of unemployed herbalists.By txt mssg referendums.By forged coups and fierce in-house branding.By the concerted efforts of well-intentioned tyrants.By quality-control clinics of hauteur-couture concepts";
		rates_phrases="pigs that cry, people that feed planes, weeping words.dust strobing particles, turbulent knots of numinosity, crushed water.plastic coats, upside down people tap-dancing, humans in bottles.aloe vera lava, maple syrup magma, sandcastle worms, soya storms.HAllucinatory content, ambiguity, no plots, some meat sculpture.arms that hold streams, rivulet ditch paradises, unfinished parables.slouching instincts, surly reservoirs, inflatable phrases.stove-top 3D, tumescent neologisms, itching sounds.lip froth, red-eye spit bubbles, mango mush, vulvas.jubilant jubilant jubilant jubilant jubilant jubilant .one by one by one by one by one by one.to the point of narcisstic black-holes that bloom to become suns.sticky, gluey, grimy, gooey, gui, smoochy, smeary.neurotic enlightenment in tablet form.some conditions apply, other conditions don't.amphetamine quad core gpu accelerated lyricism.not really listening because already somehow preoccupied.served fresh with propogandic fog.scandal fetish hormone trigger morsel gear rogue.osmosis fragile lithe epiphanies.beginning here and continuing into the post-human post-sex era.phone sex drug train cell mute love.crunchy malignancies, psychic torsion, meat in blenders.Combinatorial poetry, generative archives, wistful scenarios.Idiosyncratic perspectives, mute tones, migrant easing functions.Tensile derivatives, rhapsodic theories, experiments that bleed buttons.Ingesting instigates recursion.Cannot be sold in stores, not suitable for sports addicts.Constraint speculations immersed in immediacy.Does not guarantee anything, is not responsible, utterly deterministic.Contraindicated for psychotic conformity.Orally edited anechoic aphorisms.Language slaves should take out implants before entering.Please turn off your cell-phones during the transmission.Remote logins are only permitted for avatars without flesh recourse.Itches irrelevance until it laughs.Ordering this online can lead to prosecution in some states.Drinking the taglines can lead to obedience damage.Facts distort in the presence of this material, data bends.Obscurely advocating a impalpable presence.Tethered spores seeking thresholds.Taste-dependent  HAllucinations.Dense emptiness at levels that provoke vertigo.Anarchic rivulets, gestating melancholia, hierarchy acne.Do not attempt this in your own home.Truncated alientation and recursive epistemologies.Perforation anxiety.Discontinuous continuities.Repetitive variations, may induce viewer passivity.Opaque state-spaces populated by inexorable timers.Implementation naps.twitch ratios may evoke recognitions.Contemplative algorithms.Contingent viewers must report experiences by email.Some reports of wound intake  HAve been verified.Fertile oblivions can damage continuity in some participants.Interactivity is minimal and may cause pain to gamers.Scuffed instincts can prove discomfiting to perfectionists.Dissected pulp may induce autonomic changes.Feels like being led blind by an inexorable truth.May illuminate localized reppresion.Mute impotency and paralysis occasionally occur.After viewing, luminous resonances  HAve been verified sprouting.Moist births, insomniac reveries, ruthless efficiency.Blood muses coated in non-linear narrativity.Things may get inside you due to this.Moderate cruft alert.Billboard pronouncement design style.May contain seeds, cannot be spit out once ingested.Contains fur, bodies and tubes of all kind.Involves protracted destabilization of conclusiveness.May provoke opinion shedding, improves circulation.Doggerel wit with absence abuse.Sensual reification dye.Forged beauty exponentially judging fragments.Chromatic jokes served with video can influence appetite.Puking redundancy  HAs been observed in some sensitive visitors.Not suitable for adults.Verified abyss.Weaning issues occur sporadically in multimedia sensitive locations.Tangent forests provoke observable disequilibrium.Glazed coma-style mutations associated with extensive use.Temporary occlusion of motion.purposefulness concurrent with inappropriate smiling.Robots eat the toes of some viewers";
		IQ_phrases="IQ OVER 120 REQUIRES ACCOMPANYING SEDATIVE OR NARCOTIC.nootropic hydergine nu me-dia.some restrictions apply, others never do.boil off that last piece of brain.intelligent awkward & desperate.sinuous knot of joy.sniper fuel for the fake parade.basted in artificial tenderness.animist prehensile and devoted.secret lust paradigm mechanic.meaningless drivel buffet driven & buffeted by meaning.believably challenging belief challenges.knots of extreme naughtiness.given over to childish joy.rippling network fetish overwear.mob locks.porn phenomena in metaphysical sauce.feel good badness done well.metabolically inclined to impatience.talking pure, measuring cure.tease density.honest dishonesty served raw.predictable disclosure.total control, some violence, fake sex.no microphones or cameras were  HArmed in the making of this serendipity.growling, porousness, trauma, strobe lights.speculative diction, puerile diatribes, exotic normalcy.strumming codecs,clip-art concepts, radical conformity.incantatory excursions of infra-human excess.sedate cushioned eye-candy for post-consumption consumers.wistful youth-begetting imagist fury.serene phenomena, some intellectual content.mass confusion side-effects.Morphing linguists, animist tweens, scale inversions.Explicit non-linearity, damp renders, computational syncopation.Smooth but not redolent tv anti-poems.Nurtures an undivided faith in uncertainty.Provokes an intimate awareness of subliminal unity.Stern erratic dream debris.Insight pheromones capable of provoking inter-brain mating.synthetic life, neglected deaths, portable aphorisms.Distributed and downloadable culture.Awakened heartfelt sincerity with overtones of humility.Miasma rants for a metamorphic era.Unstable bubble snags, aka 'troubles'.Peace tornadoes constructed from modular code and moist data.Vague flexible alphabets.Dancing letters, slow vortices, lush torsion.Serendipity ether.Idiomatic scraps, mild bewilderment, cognitive caulking.Pulse topology psychometrics.media pioneering, sod-hut interfaces.Anabolic surrealism, stability wrinkles, innocent tundra.Soft loops, sardonic wishes, dissected ingestion.Question's metabolism, dense nodes of gentleness.Input excess, talking light, flesh ricochets.Autonomous misnomers, prosthetic illusions, hybrid effects.Crisis misanthropy explorations that lead toward love.Sinuous communication arising from a luminous source.scrutiny residue screen ligature.Dissident mind-wash for a distributed generation.Excess discourse for an excessive epoch.Meridian juggling, some funny shit, emptiness in an URL. WARNING: SOUR WEB ATHEISM.Prejudice-soluble sub-conscious muzak.Amniotic cities fabricated from  Hallucinations.Generative trivia batch-rendered to custom specs.Tripod bleeding, autobiographical recycling.Anointed modules, opalescent plug-ins, incremental intuitions.Temporal wash points in a dry cycle.Swearing, inappropriate metaphors, home-made costumes.Beat windows, mutilated syntax, fresh numbness.Helix plumbing, involution labyrinths, basic incomprehensibility.Speck executables, inbox excreta, random thoughts.Gutter nuts putting shut splutter stutters.Yapping at society, contagious difference, micro landscapes.Binary analogs, dangling precipices, desiccated oceans.Tentative experiments toward a personal digital poetics.Reverence disclosures gorging on concentrated contradictions.Entrails tautology, mutable logic, sniff toys.Lithe metabolically-enhanced virtual virtuosity.Core root skin ions.Radiant play flares.Voice socket diffusion.What is said here, need never be repeated or forgotten.Unsaid things that think themselves not things.Weak  Hacks of vulnerable circumstances.Ephemeral pop take-in scratches, burly effluence.Acronym jock-straps, crush conversions, flock gates.message actuated conduit networks";

		//french
		follow_phrases_fr = "les vidéos SUIVANTS SONT APPROUVÉS.le film SUIVANT est APPROUVÉ.Le livre SUIVANT est APPROUVÉ.le programme SUIVANT est APPROUVÉ.l' activité SUIVANTe est APPROUVÉe.le culte SUIVANT est APPROUVÉ.le produit culturel SUIVANT est APPROUVÉ.la présentation SUIVANTe est APPROUVÉe.l' idéologie  SUIVANTe est APPROUVÉe.La conférence SUIVANTe est APPROUVÉe.Les articles suivants sont approuvés.Le processus SUIVANT est APPROUVÉ.l' aperçu SUIVANT est APPROUVÉ.la poubelle SUIVANTe est APPROUVÉe.le chef SUIVANT est APPROUVÉ.La distraction SUIVANTe est APPROUVÉe.le SITE-INTERNET SUIVANT est APPROUVÉ.le sujet SUIVANT est APPROUVÉ.le noeud-participatif SUIVANT est APPROUVÉ.le rapport SUIVANT est APPROUVÉ.La station  SUIVANTe est APPROUVÉe.le parchemin SUIVANT est APPROUVÉ.le stimulus SUIVANT est APPROUVÉ.le poème SUIVANT est APPROUVÉ.le non-sens SUIVANT est APPROUVÉ.La performance SUIVANTe est APPROUVÉe.l' incantation SUIVANTe est APPROUVÉe.La parabole  SUIVANTe est APPROUVÉe.l' hologramme SUIVANT est APPROUVÉ.l' érotisme SUIVANT est APPROUVÉ.le rêve SUIVANT est APPROUVÉ.La Révélation SUIVANTe est APPROUVÉe.Le soap-opera SUIVANT est APPROUVÉ.La thèse SUIVANTe est APPROUVÉe.l' Interface SUIVANTe est APPROUVÉe.La chanson SUIVANTe est APPROUVÉe.le mashup SUIVANT est APPROUVÉ.le réseau SUIVANT est APPROUVÉ.l' aberration-mentale SUIVANTe est APPROUVÉe.le réservoir SUIVANT est APPROUVÉ.La TV SUIVANTe est APPROUVÉe.La technologie SUIVANTe est APPROUVÉe.l' appareil SUIVANT est APPROUVÉ.Le Symbole SUIVANT est APPROUVÉ.le trou noir SUIVANT est APPROUVÉ.Le eye-candy SUIVANT est APPROUVÉ.La confession SUIVANTe est APPROUVÉe.La membrane  SUIVANTe est APPROUVÉe.l' expérience  SUIVANTe est APPROUVÉe.l' enquête SUIVANTe est APPROUVÉe.La recherche SUIVANTe est APPROUVÉe.l' art SUIVANT est APPROUVÉ.le vidéo-poème SUIVANT est APPROUVÉ.l' installation SUIVANTe est APPROUVÉe.l' idéologie SUIVANTe est APPROUVÉe.l' esthétique SUIVANTe est APPROUVÉe.La critique SUIVANTe est APPROUVÉe.l' avis suivant est approuvé.l' heureux hasard est approuvé.l' Epiphanie SUIVANTe est APPROUVÉe.La rétraction SUIVANTe est APPROUVÉe.La culture SUIVANTe est APPROUVÉe.La Drogue SUIVANTe est APPROUVÉe.l' Exposition SUIVANTe est APPROUVÉe.Le Spectacle SUIVANT est APPROUVÉ.la Loi SUIVANTe est APPROUVÉe.La Cérémonie  SUIVANTe est APPROUVÉe.les travaux SUIVANTs sont APPROUVÉs.la réalisation SUIVANTe est APPROUVÉe";
		rates_fr = "Contaminées,ondulantes,délirantes,fertiles,gracieuses,affamées,morbides,nécessiteuses,inquiètes,serviles,vierges,freak,Geek,hacktivistes,procédures,durables,illicites,déjectées,népotistes,maussades,indifférentes,labiales,contemporaines,cancérigènes,malodorantes,indécises,prépayées,invraisemblables,oculaires,frénétiques,louches,interrogatives,pacifiques,acariâtres,mystifiées,rapides,ergodiques,douteuses,liquéfiées,amorcées,nonsubmergibles,ésotériques,vénérées,synthétiques,tactiles,confondues,grésillantes,compétentes,efficaces ,méticuleuses,dénoyautées,violentes,plaisantes,au cœur gros,polémiques,spatiales,décongelées,conservatrices,intercellulaires,obséquieuses,détachées,brusques,oscillantes,sous-alimentées,religieuses,idiotes,relationnelles,merveilleuses,tressées,queer,décoratives,empathiques,résistantes au feu ,absurdes,belles,tordues,ingénues,expertes,grumeleuses,sans passion,psychogènes,durables,banales,misanthropes,solides,collaboratives,stupides,surveillées,avunculaires,séditieuses,homéostatiques,pratiques,jubilatoires,subalternes,insécures,obscènes,émotives,bouclées,insipides,pures,ivres,fatiguées,aimables,sentimentales,courbées,déclinées,vivantes,calmes,non civilisées,indigestes,sans-prétention,solides,authentiques,écrasées,déprimées,horny,insécures,vigilantes,proactives,en sueur";
		by_phrases_fr = "Par une coalition abandonnée de créateurs marginaux.Par la Société pour la préservation de la créativité sur Internet.Par l' ASSOCIATION des poÈtes visuels du CANADA, INC.par la branche récidiviste rétroactive de votre super-ego.par un petit groupe népotiste des élites culturelles.par la loi du peuple.par le comité pour la perpétuation de la fermeture.par la société pour la négation active.par la Direction générale de la base de votre identité.par le groupement d'intérêt public pour la sécurité de la psyché.par le groupe de pression d'anesthésie intégrée.par le parti international d'action pour la décimation des aberrations.Par une alliance révolutionnaire de propriétaires robots.Par l'union de la censure démocratique.Par le Parti progressiste pour la suppression des partis.Par un groupe de citoyens concernés, tout comme vous.Par un processus autocratique que personne ne comprend vraiment.Par une seule personne quelque part inconnue.Par un algorithme conçu pour émuler le sens commun.Par un désir de profit technologique intégrée.Par le Forum pour la pureté du monde.Par l'initiative de protéger la société contre l'auto-destruction.Par un processus consensuel qui a eu plusieurs décennies.Par les partisans des méthodes aléatoires.Par des gens comme vous.Par les forces en place.Par les jugements  téméraires et impotents d'agents sous-payés.par l'arrogance résiliente de la force élastique des animaux.Par des protectionnistes vulnérables, primates idéologiquement contestés.par des nœuds denses de dendrites ambulatoires.Par réflexes métaphysiques pré-mastiqués.par le groupe d'étude de l'évolution de la censure.par les fluctuations saisonnières des opinions migratoires.par les groupes de défense convoqués en secret au sein de votre chair.par une loterie  truquée.par la gravité absurde du vote.Par le comité de significations mélangées.En passant le spam au tamis jusqu'à ce qu'il semble raisonnable.Par tâtonnement et rationalisation.Par tyrannie sauvage et autocratisme obscure.Par la conversion de mesures quantitatives en qualités sociales.Par la fatalité d'un système de vibration qui imprègne tout.Par le sang et le traffic d'hormones de bureaucrates.Par des laboratoires sophistiqués dédiés à votre protection personnelle.Par une entité altruiste.Par la pensée abstraite s'accouplant avec la réalité physique.Par une peur profonde de toutes nouveautés.Par la douceur des formes fugitives volcaniques.Par la coopérative pour les mutations contrôlées.Par la la Société de recherche pour les décisions canoniques.Par un brouillard né de la subjectivité.Par un processus émergent.En rougissant assidûment et accumulant la couleur.Par le Département des contraintes synthétiques.Par un fonctionnaire anonymement élu.En connectant votre IP dans une base de données criminelles.En supervisant les amibes comme commis d'entrée de données.En marchant dans les rues contre la liberté.En établissant des critères de références cryptées.En trempant des synapses dans la pure lumière à une vitesse infinie.Par les dirigeants consacrés à des alternatives radicales.Par l'adjoint administratif à temps partiel du conseil non syndiqué.Par un ordinateur central qui est plus intelligent que vous.Par des patrons qui pensent à vous.Par des systèmes universels qui sont incontestables.Par l'intelligence artificielle distribuée dans les aliments.Par des personnes puissantes criblées de doute.Par la négligence et la synchronicité.Par le Comité pour la destitution de l'individualité.Par des employés de bureau superflus dans leur temps libre.En vertu d'un processus automatisé en ligne.Par Opérations aléatoires appliquées à un ensemble de données non pertinentes.Par extra terrestres errants télépathes et mystiques.Par un gouvernement qui n'a aucun pouvoir.Par des anarchistes qui vivent dans les banlieues.Par des agents de surveillance qui ont lu vos e-mail pour deviner ce que vous vouliez.Par les enfants titulaires dans les toilettes d'exploitation.Par ordonnance d'un règlement obscur.Par un complot aléatoire qui vient d'avoir lieu au travail.En fonction d'analyse intrinsèque et processus stochastiques.En agrégeant des opinions secretes.Par clans d'intuitions aliénées.Par des foules intelligentes libérées dans les environnements virtuels.Par un chien qui a le QI d'un génie.Par un troupeau de phoques migrateurs équipés de colliers multi-touches.Par  souhaits coquins récoltés à partir de formulaires du gouvernement.Par l'Alliance pour l'approbation de la négativité.Par le Partenariat pour un public pénitent.Par l'union de tous les censeurs non-syndiqués .Par le placement d'un produit qui implique plus d'argent que nous pouvons mentionner.Par une tribu d'affiliations incompétentes.Par un secret tribunal, pendant de nombreuses années.Par la matière sous-privilégiée qui compose votre corps.En fusionnant les cliques de la masse critique.Par la coopérative qui fixe des limites triviales.Par un détournement arbitraire.En déduisant la valeur nette de la valeur du temps perdu.Par une foule de chômeurs herboristes.Par référendums messages textos.Par coups d'états forgés et le brand marketing féroce.Par les efforts concertés de tyrans bien intentionnés.Par les cliniques de contrôle de qualité de concepts haute-couture";		
		rates_phrases_fr = "porcs qui crient, les gens qui alimentent les avions, des mots qui pleurent. les particules de poussière stroboscopique, noeuds de numinosité turbulente, l'eau écrasée. manteaux en plastique, les gens dansant les claquettes, la tête en bas, les êtres humains dans des bouteilles. de la lave d’aloe vera, le magma de sirop d'érable, les vers de châteaux de sable, les tempêtes de soja.Le contenu hallucinatoire, l'ambiguïté, aucun déroulement, des parcelles de sculpture de viande.Des bras qui tiennent les cours d'eau, paradis au ruisseaux narcissiques, paraboles inachevées. Des instincts affalés, des réservoirs hargneux, des phrases gonflables. Des cuisinières 3D, néologismes tumescentes, Des sons qui démangent. les lèvres mousseuses, des yeux rouges qui crachent des bulles, de la purée de mangue, vulves. jubilant jubilant jubilation liesse liesse liesse. un par un par un par un par un par un. De narcissiques trous noirs qui fleurissent à en devenir des soleils. collant, gluant, sale, visqueux, poisseux,âcre, pâteux. Illumination névrotique sous forme de comprimés. Certaines conditions s'appliquent, les autres conditions ne s’appliquent pas. amphétamine à de base lyrisme accéléré. pas vraiment à l'écoute parce que déjà en quelque sorte préoccupé. Servir frais avec de la propagande brumeuse. (fetish hormone scandale déclenchement engins voyous morceau.)? épiphanies osmose souple fragile. débute ici et continue dans l'ère post-humain post-sexe.Cellulaires, trains, sexe, drogues,amour muet. tumeurs croquantes, torsion psychique,viande broyées dans les mélangeurs. la poésie combinatoire, archives qui génèrent les scénarios mélancoliques. perspectives idiosyncrasiques, tons muets, les fonctions assouplissantes qui migrent. dérivés à la traction, les théories rhapsodiques, des expérimentations qui saignent des boutons. L'ingestion provoque la récursivité. Ne peut être vendu dans les magasins, ne convient pas pour les accros du sport. Speculations Contraintes plongées dans l'immédiateté. Ne garantit rien, n'est pas responsable, totalement déterministe. Contre-indiqué pour la conformité psychotique. Oralement édité par aphorismes muets. les esclaves de la Langue devraient prendre des implants avant d'entrer. S'il vous plaît éteindre votre téléphones cellulaires au cours de la transmission.Les Connexions à distance ne sont autorisées que pour les avatars, sans recours chair. Chatouille l’irréverance jusqu'à ce qu'il rit. Commande en ligne de ce produit peut entraîner des poursuites dans certains États. De boire les étiquettes peut entraîner des dommages à l’ obéissance. Les Faits sont faussés par la présence de ce materiel, les données se penchent. préconise une presence Obscure et impalpable. des spores captifs qui recherchent des seuils. Hallucinations qui créent une dépendance au niveau des papilles gustatives. Des vides denses qui provoquent le vertige. ruisseaux anarchiques, gestation mélancolique acné hiérarchique. Ne tentez pas ceci dans votre propre maison. alienation tronquée et épistémologies récursives. Anxiété de la Perforation. continuités discontinues. variations répétitives, peuvent induire la passivité du spectateur. Etat Opaque des espaces habités par des minuteries inexorables. PAN mise en œuvre.Secousses de ratios peuvent évoquer desreconnaissances. algorithmes contemplatifs. téléspectateurs contingents doivent présenter un rapport par e-mail. Certains rapports de l'ingestion de plaies ont été vérifiées. Les fertiles oublis peuvent endommager la continuité chez certains participants. L'interactivitéminimepeut causer des douleurs aux joueurs. Instincts épidermés peuvent s'avérer troublants pour les perfectionnistes. La pâte disséquée peut induire des changements autonomes. On peut se sentir entraîné par une aveugle inexorable vérité.Localise la répression. L'impuissance et la paralysiemuettes surviennent parfois. Après le visionnement,il a été vérifié que les résonances lumineuses sont en germination. Naissance humides, rêveries insomniaques, Efficacité impitoyable. Blood muses sanguinaires enrobées de narrativité non-linéaire. Les choses risquent pénétrer à l'intérieur vous. Alerte; embrouillement modéré. Affichage style design prononcé. Peut contenir des graines, ne peuvent pas être recrachés une fois ingérés. Contient de la fourrure, des organismes et des tubes de toutes sortes. Implique une déstabilisation prolongée de force probante. Peut provoquer une effusion d'opinions, améliore la circulation. Esprit qui abuse de l'absence. Colorant de réification sensuelle. Beauté forgée de jugements exponentiels. Blagues Chromatiques servies avec la vidéo peuvent influencer l'appétit. Le vomissement redondant a été observé chez certains visiteurs sensibles. Ne convient pas pour les adultes.Abîme vérifié. problèmes de sevrage se produisent sporadiquement dans des endroitsde multimédia sensibles. forêts Tangents provoquent un déséquilibre observable.A l'utilisation extensive certaines mutations émaillées de style ont pu être observés. Occlusion temporaire du mouvement. Détermination simultanée de sourire inapproprié. Robots peuvent manger les orteils de certains téléspectateurs";
		IQ_phrases_fr = "QI plus de 120 doivent être accompagnés par un sédatif ou narcotique. Hydergine nootropique media.Certaines restrictions s'appliquent, d'autres jamais.faire bouillir ce dernier morceau de cerveau.intelligent et maladroit désespéré.noeud sinueux de joie.sniper de carburant pour le faux défilé.arrosée de tendresse artificielle.préhensiles animistes et dévoués.Méchanismes secrets du paradigme de la luxure.Buffet de non sens.Croyances défiées.Des noeuds de malice extrême.consacrés à la joie enfantine.ondulation-vêtements réseau  fetish. Embouteillages de foules.phénomènes porno à la sauce métaphysique.Se sentir bien dans la méchanceté bien faite.métaboliquement inclinés à l'impatience.parler purement de la mesure de  guérison.Dense séduction taquine. Honnêteté malhonnête servie crue.Divulgation prévisible.Contrôle total, une certaine violence, le faux sexe.Aucun microphone ou caméra a été blessé dans la réalisation de ce heureux hasard .La porosité des traumatismes stroboscopiques.diction spéculative, diatribes puériles et de la normalité exotique.strumming codecs, concepts clip-art, de la conformité radicale.excursions incantatoires des excès infra-humains.Bonbons calmants pour les consommateurs post-consommation.La fureur mélancolique de l”engendrement de la jeunesse.phénomènes sereins, un peu de contenu intellectuel.masse confuse des effets secondaires.Transmutation des linguistes, Interpolations animistes a échelles inversées.Non-linéarité explicite a rendement humide, syncopes de calcul.Lisse, mais ne respire anti tv-poèmes.Nourrit une foi inébranlable dans l'incertitude.Provoque une prise de conscience intime de l'unité subliminale.Débris erratiques de rêves séveres.Phéromones capables de provoquer l'accouplement inter-encéphalique.vie synthétique, décès  négligé, aphorismes portables.Cultures téléchargeables.Coeur sincère éveillé avec des accents d'humilité.Rouspètage dans une ère métamorphique.Chicots de bulles instables, alias «troubles».tornades de paix construites à partir du code modulaire et des données humides.Alphabets vagues et flexibles.lettres qui  dansent, les tourbillons lents, torsion luxuriante.Le hasardde l' éther.déchets idiomatiques, stupeur légère, calfeutrage cognitive. Pouls psychométrique topologique.médias de pionnier, interface maison de papier.surréaliste anabolisantes, la stabilité des rides, la toundra innocente.boucles souples, souhaits sardoniques, ingestion disséquée.Question de métabolisme, les nœuds denses de douceur.excès d'entrée, en parlant de lumière ricochets chair.misnomères autonomes, les illusions de prothèse, effets hybrides.Crises de misanthropie qui mènent  a l'amour.Communication sinueuse découlant d'une source lumineuse.Ecran ligaturé qui contrôle les résidus.Esprit de lavage pour une production décentralisée.discours excessifs d'une époque excessive.jongler avec les meridiens, de la drôle de merde, le vide dans une URL.AVERTISSEMENT: l'athéisme dans le WEB amère. Muzak soluble et subconsciente.Villes amniotique fabriquées à partir d'hallucinations.Information générique pour spécifications personnalisées.Saignements de trépied, le recyclage autobiographique.modules bénis, prises opalescentes des intuitions supplémentaires.points de lavage dans un cycle de séchage.Prestations de blasphèmes, les métaphores inadéquates, costumes faits maison.Windows Beat, syntaxe mutilée de l'engourdissement frais.Labyrinthes d' involution, incompréhensibilité de base.Poussières d'éxécution, excréments boîte de réception, des pensées aléatoires.noix de gouttières bégaient et crépitent.Japper une différence contagieuse dans les paysages micro.analogues binaires, de précipices qui ne tiennent qu'a un fil, des océans desséchés.tâtonnements vers une poétique personnelle numérique.divulgations Révérencielles qui se gavent de contradictions concentrées.Entrailles tautologiques, la logique en mutation de jouets a renifler.Virtuosité souple métaboliquement améliorée.Ions peau racine.Jeux de fusées Radieuse.diffusion des prises de voix.Ce qui est dit ici, ne peut être ni répété ni oublié.les non-dits qui se pensent.Hacks fait de la vulnérabilité.Ephémère pop d'affluence tordue.Un jock-strap d'acronymes, conversions écrasées, portes pour le troupeau.message actionné par les réseaux de conduits";

		//Chinese
		follow_phrases_cn = "錄像.電影.書藉.程式.活動.邪典電影.文化產品.報告.意識形態.演講.文章.過程.預覽.垃圾.代表作.消遣.網站.主題.參與筆記.報告.車站.古本手卷.興奮劑.詩歌.廢話.表演.咒語.寓言.全息圖.咸書.夢想.啟示.肥皂劇.論文.界面.歌曲.混搭.網絡.精神失常.水庫.電視.技術.設備.象徵.黑洞.視覺糖果.告解.薄膜.經驗.調查.研究.藝術.視像詩歌.裝置.意識形態.美學.評論.報章評論.感召.頓悟.撤回聲明.文化.藥物.展覽.奇觀.法律.儀式.工作.成就";
		rates_cn = "腐壞的,波浪形的,神志不清的,肥沃的,親切的,飢餓的,畸型的,有需要的,躁動不安的,卑微的,還是處女的,怪胎的,古怪的,身分是黑客的,程序性的,堅固耐用的,非法的,垃圾的,裙腳仔的,悶悶不樂的,冷漠的,多心的,當代的,致癌的,有異味的,善變的,投幣式,令人難以置信的,眼部的,瘋狂的,卑劣的,疑問句,和平的,潑辣的,迷惑的,性急的,歷盡滄桑的,狡猾的,已被液化的,原始的,不能潛航的,神秘的,受人敬重的,合成的,有手感的,困惑的,熾熱的,學識淵博的,有效率的,一絲不苟的,烏了的,暴力的,風度翩翩的,憂心忡忡的,愛爭辯的,時空的,解凍後的,保守的,在細胞隙罅之間的,低三下四的,抽離的,生硬的,浮動的,營養不良的,虔誠的,白痴,有關連的,了不起的,編織的,酷兒,用作裝飾的,具同理心的,防火的,荒謬的,美麗的,無賴,天真的,專家的,流氓的,冷靜的,精神性,堅固耐用的,老套的,憤世嫉俗的,紮實的,共同合作的,愚蠢的, 謹慎的,關懷備至的,具煽動性的,動態均衡的,實用的,興高采烈的,卑躬屈膝的,缺乏安全感的,下流的,情緒化的,糊塗的,平淡的,清純的,醉了的,筋疲力盡的,善良的,多愁善感的,彎曲的,逐漸消退的,活著的,平靜的,野蠻的,難以消化的,樸素的,紮實的,原創的,壓碎了的,抑鬱的,性欲強的,缺乏安全感的,警覺性強的,積極進取的,大汗的";
		by_phrases_cn = " 邊緣創作者廢棄聯盟. 互聯網創意保護學會. 加拿大視覺詩詞協會有限公司. 超我痙攣反動慣犯分行. 文化精英的裙帶小組. 私刑. 持續關閉委員會. 主動否缺社團. 你的核心身份企業分行. 心理安全公益團體. 綜合麻醉遊說團. 畸怪滅殺國際行動黨. 革命性專屬機器人聯盟. 民主審查的工會. 取消黨派進步黨. 像你一樣公民關注組. 沒有人真正理解的獨裁程序. 不知從何來的一個人. 設計模擬何謂常識的算法. 集成技術而獲利的慾望. 純潔世界論壇. 透過自我毀滅而主動保護協團. 花了幾十年的協商一致過程. 隨機方法論的擁護者. 像你一樣的人. 存在宇宙間的力量. 工資較低員工的無能和魯莽的判斷. 彈性動物的堅韌囂張氣焰. 挑戰靈長類動物的溫柔保護主義思想家. 會走動的樹模石的稠密支節. 預先咀嚼的形而上學反射. 進化審查研研的工作小組. 季節性波動的遷徙意見. 於肉中召開秘密會議的倡導組織. 做了手腳的抽獎活動. 可笑得認真的投票. 反覆改變意義的委員會. 通過篩選垃圾郵件，直到它看似合理. 猜測和合理化. 野蠻專制和黑暗暴政. 測量控制轉化為社會素質. 一個系統的振動必然性能貫穿所有物件. 官員的血液和荷爾蒙流量. 致力於你的個人防護的精密實驗室. 一種利他主義實體. 抽象思維與物理現實交配. 害怕任何新事物的根深蒂固恐懼. 由火山形成的短暫性柔軟度. 突變受控合作社. 研究協會的慣常決定. 源於主觀性的霧. 緊急程序. 努力地紅著臉和收集顏色. 人造約束部門. 由顧問和匿名人士選出來的官員. 通過登錄你的IP而變成犯罪的數據庫. 監督變形蟲為數據輸入員. 透過遊行上街反對自由. 建立某些加密底線的標準. 在無限速度浸泡突觸在純淨的光線之中. 致力於激進可行方案的管理人員. 行政助理的兼職非工會委員會. 比你聰明的電腦主機. 真正關心的老闆.毋庸置疑的通用系統. 分佈於食物中的人工智能. 透過指揮充滿了懷疑的人. 疏忽和同步. 個性彈劾小組. 在業餘時間的冗餘的上班族. 自動化網絡處理. 機會操作應用於不相關的數據集當中. 無家可歸又能心靈感應的神秘外星人. 沒有權力的政府. 住在郊區的無政府主義者. 透過讀取電子郵件便能猜測你想要甚麼的監控員. 在血汗工廠廁所永久聘任的兒童. 模糊的附例執行令. 只涉及工作的隨機制度. 內在的特徵分析的隨機過程. 整合機密的建議. 自我隔離直覺包裹. 解放到虛擬世界裡頭中的智能小魔怪. 擁有天才智商的狗. 配備多觸式頸圈的遷徙海豹. By rogue wishes harvested from government forms. 負面簽署聯盟. 公眾懺悔夥伴關係. 無工會審查的會. 更多金錢可被提及的產品展示位置.無能聯繫關係的部落. 運作多年的秘密法庭. 弱勢情形令你的身體變得強壯. 透過合併派系直到臨界點. 瑣碎限制合作社. 任意變形群組. 從浪費了的時間扣除你的資產淨值. 失業中醫師. 短信公投. 偽造政變和激烈的內部品牌推廣. 善意獨裁者的共同努力. 傲慢時裝概念的質量控制診所";
		rates_phrases_cn=" 流淚的豬，餵飛機進食的群眾，哭泣的詞語. 閃爍塵埃粒子，超自然動盪支結，破碎的水. 膠外套，人們倒轉身跳踢踏舞，人類在樽子裡. 蘆薈熔岩, 楓糖漿岩漿，沙堡蠕蟲，大豆風暴.迷幻的內容，含糊不清，沒有情節，有一些肉做的雕塑. 緊握的手臂在飄流，小溪溝渠天堂, 懶散天性，暴躁水塘，誇張的片語. slouching instincts, surly reservoirs, inflatable phrases. 3D灶頭，腫脹的新詞匯，發癢的聲音. 珠唇嘔泡，紅眼晴嘔泡，芒果糊仔，外陰. 喜氣洋洋 喜氣洋洋 喜氣洋洋 喜氣洋洋 喜氣洋洋 喜氣洋洋. 一個接一個接一個接一個接一個. 直到自戀的黑洞綻放成為太陽. 黐，貼， 黏，污穢，龜，浪漫，油污. 神經質啟示以藥片形式出現. 有些條件適用，有些卻不. 由安非他明四核心處理器加速的詩意. 因為腦袋很忙，所以不是真的在聽. 新鮮享用文宣青蛙. 醜聞戀物激素觸發起一片齒輪式惡霸. 具滲透性而又柔軟和脆弱的頓悟. 從這裡開始，一直至後人類和後性別時代. 電話性愛毒品火車細胞靜音愛. 鬆脆腫瘤，心理不平衡，有團肉在攪拌機裡. 詩歌組合, 衍生資料庫，依戀的情景. 特殊的觀點，靜音鈴聲，流動放鬆功能. 具伸縮性的衍生物，狂想的理論，流出按鈕狀的血的實驗. 咽下慫恿遞迴式. 不能在商店出售，不適合運動狂. 限制性的投機浸淫在當下. 不保證任何事情，不負責任，完全確定. 精神病共通的禁忌. 經已修改的口頭消音格言. 語言奴隸拿出植入體才可進入. 請在傳輸過程中關掉你的手提電話. 遠程登錄只允許無需依賴肉身的虛擬人偶使用. 無關痛癢一直在笑. 在一些州份，於網上訂購這個可遭檢控. 飲用品牌標語可導致服從性的損害. 因著這物料的出現，事實扭曲，數據失真. 隱晦地推動一種無法被觸摸的存在. 被束縛的孢子在尋找門檻. 口感依賴幻覺. 密集空虛引發到昏眩的程度. 無政府的溪流，妊娠憂鬱症，階級粉刺. 不要在自己家裡嘗試做這個. 截斷隔離遞推認知論. 穿孔焦慮症. 間斷的連續性. 重複的變化可能會令觀眾變得被動. 無情的計時器充斥著這個不透明空間. 實施午睡. 抽搐比率可能會激發起識別能力. 冥想算法. 特遣隊觀眾必須通過電子郵件回報經驗. 一些有關傷口攝取量的報導已經被證實. 一些參與者的活躍遺忘狀態可遭至破壞. 互動性是微小的，亦可做成玩家疼痛. 憑著磨損了的直覺，便能向完美主義者證實尷尬的存在. 解剖已取出來的漿糊物，可能會誘發自主神經的變化. 感覺就像盲目地追從一種必然的真理. 照亮地區性抑壓. 靜音性無能和麻痺偶爾會發生. 在觀看後，發光的共鳴已經被核實為正在萌芽. 濕潤分娩，失眠狂想，無情的效率. 血腥繆斯女神被塗在非線性的敘事上. 緣於此，事情可能會進入你內心. 溫和廢話警示. 廣告牌聲明的設計風格. 可能含有種子，一旦誤食，無法吐出. 含有皮草，身體和所有類型的管. 包括長期不穩的定論. 可能會引起輿論的剝落，促進血液循環. 打油詩機智和濫用缺席. 感性物化染料. 偽造的美麗指數評審片段. 彩色笑話配上視頻能夠影響食慾. 一些敏感遊客的嘔吐物已被觀察. 不適合成年人. 驗證深淵. 斷奶的問題偶爾會出現在多媒體敏感位置. 正切森林引發起可見的不平衡. 呆滯昏迷式突變與廣泛使用的關聯. 動作暫時性動作閉塞. 有明確目標同時不不恰當地微笑著. 機器人吃了一些觀眾的腳趾";
		IQ_phrases_cn="智商超過120需配帶鎮定劑或麻醉藥. nootropic hydergine nu me-dia. 某些限制適用，有些卻不. 蒸發最後一片大腦. 智能的尷尬與絕望. 喜悅的彎曲繩結. 為假遊行準備的狙擊燃料. 塗上人工柔情. 泛靈論者的捲纏與奉獻. 秘密情慾範例技巧. 亂碼自助餐驅動並任由意思挨打. 具挑戰性的事情挑戰信念. 極度頑皮的結. 讓自己擁有孩子般的喜悅. 蕩漾的網絡，戀物者佩帶了太多東西. 暴徒鎖上. 在形而上醬油的色情現象. 為壞事做得好而感到高興. 新陳代謝傾向於不耐煩. 純潔交談, 醫治腦癌. 整蠱密度. honest dishonesty served raw. 可預測的披露. 完全控制，一些暴力行為，假冒色情. no microphones or cameras were HArmed in the making of this serendipity. 咆哮, 多孔, 心理創傷, 閃光燈. 投機性用語，幼稚的抨擊，充滿異國情調的常態. 彈撥解碼器，剪貼畫集的概念，激進的一致性. 過剩人猿的咒語般旅行. 給後消費時代消費者的安靜而又舒適的視覺盛宴. 既充滿盼望而又能使你變得更年青的意象派憤怒. 寧靜的現象，有一些學術內容. 大規模混亂的副作用. 變形的語言學家介乎於泛靈論者之間，比例倒轉. 明顯的非線性，潮濕的渲染，計算性切分節奏. 流暢而又充滿情懷的電視反詩歌. 在不確定的領域中培養不可分割的信仰. 激發起對下意識協調的親密認知. 夢中苛刻而又古怪的零碎片段. 具洞察力的信息素能夠挑起腦袋與腦袋之間的感應. 合成生命，被棄置的死屍，便攜式格言. 分佈和可下載的文化. 喚醒由衷的誠懇和謙卑的弦外之音. 瘴氣怒罵的變質時代. 不穩定泡沫障礙，又稱之為“煩惱”. 和平龍捲風從模塊化代碼和濕潤數據建構而成. 含糊靈活字母. 舞動的信件，緩慢旋渦，華麗地扭轉. 意外地發現乙醚. 慣用語碎片，輕度迷惘，認知填縫. 脈衝的拓撲心理測驗. 傳媒先鋒，草皮茅屋界面. 製造超現實主義，穩定性皺紋，無辜的苔原. 柔軟的循環，諷刺的願望，解剖攝取. 問題的新陳代謝，溫柔的密集據點. 輸入過剩，說話無力，有舊肉在彈跳. 自主性用詞不當，義肢的幻想，混合效果. 從危機中憤世嫉俗的探索，引發到愛的出現. 從發光源引起的正弦交流. 經過詳細檢查, 發現結紮線殘餘於屏幕之中. 為了散落四週的一代，異見人士進行洗腦. 多餘的論述給過剩的時代. 在經線上雜耍，一些搞笑的東西， 網址裡的空虛. 警告：酸味網址無神論. 可溶性偏見的潛意識襯托音樂. 幻想出來的羊水城市. 一批衍生小事渲染成自定格式. 三腳架出血，自傳性回收. 受膏的組件，乳白色的插件， 直覺遞增. 在乾燥週期的時空清潔點. 講粗口，不恰當的比喻，自家服飾. 敲打窗口，殘缺不全的語法，新添的麻木. 螺旋管道，錯綜複雜的迷宮，基本上無法理解.帶有斑點的執行程序，收件箱中的排泄物，胡思亂想. Gutter nuts putting shut splutter stutters. 在社會瓜瓜叫，傳染性差異，微型景觀. 二元相似物，搖晃的懸崖峭壁，乾涸的海洋. 邁向個人數碼化詩意的試探性的實驗. Reverence disclosures gorging on concentrated contradictions. 大腸邏輯真句，無常的邏輯，聞了一聞玩具. 輕盈而促進了新陳代謝的虛擬絕技. 核心根本皮膚離子. 輻射玩弄照明彈. 語音廣播插頭. 在這裡所做說，永遠不需被重複或遺忘. 還未說出口的東西認為自己不是個東西. 在脆弱的情況下的軟弱黑客. 接受流行所做成的短暫刮痕，流出結實的東西. 吊帶內褲的縮寫，粉碎對話，蜂擁而至到大門. 消息驅動管道網絡";

		ratings_I = "I,II,III,IV,V,VI,VII,VIII,IX,X";
		ratings_A = "A,B,C,D";

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

		ar_follow_phrases_cn = new List<string>(follow_phrases_cn.Split ('.'));
		ar_rates_cn = new List<string>(rates_cn.Split (','));
		ar_by_phrases_cn = new List<string>(by_phrases_cn.Split ('.'));
		ar_rates_phrases_cn = new List<string>(rates_phrases_cn.Split ('.'));
		ar_IQ_phrases_cn = new List<string>(IQ_phrases_cn.Split ('.'));

		ar_ratings_A = new List<string> (ratings_A.Split (','));
		ar_ratings_I = new List<string> (ratings_I.Split (','));


		/*
		Debug.Log (ar_rates_phrases_cn.Count + ", " + ar_rates_phrases_fr.Count + ", " + ar_rates_phrases.Count);
		for (int i = 0; i<84; i++) {
			Debug.Log (ar_rates_phrases[i] + " :::: " + ar_rates_phrases_cn[i]);
		}
		*/

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
		timer -= 0.015f;//Time.deltaTime;
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
		string tempFollowPh = ar_follow_phrases_cn [rdn];

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


		/*** By ***/
		rdn = rdnNo.Next (0, ar_by_phrases.Count);
		txtBy.text = (ar_by_phrases[rdn]).ToUpper();
		txtBy_fr.text = (ar_by_phrases_fr[rdn]).ToUpper();
		string tempByPh = ar_by_phrases_cn[rdn];


		/*** Rates ***/
		rdn = rdnNo.Next (0, ar_rates.Count);
		txtRates.text = (ar_rates[rdn] + " AUDIENCES").ToUpper();
		txtRates_fr.text = (ar_rates_fr[rdn] + " AUDIENCES").ToUpper();
		string tempRates = ar_rates_cn[rdn];
		//txtRates2.text = (ar_rates[rdn] + " AUDIENCES").ToUpper();
		//txtRates_cn2.text = (ar_rates_cn[rdn] + " 讀者").ToUpper();



		txtRates_cn.text = "以下的 " + tempFollowPh + " 已獲" + tempByPh + " 批核";
		txtBy_cn.text = "以供 " + tempRates + " 觀眾收看";//txtRates_cn.text = (ar_rates_cn[rdn] + " 讀者").ToUpper();


		//txtBy_cn.text = (ar_by_phrases_cn[rdn]).ToUpper();
		//txtBy2.text = (ar_by_phrases[rdn]).ToUpper();
		//txtBy_cn2.text = (ar_by_phrases_cn[rdn]).ToUpper();
		
		/*** Rates_Big ***/
		txtRatesBig.text = (ar_rates[rdn]).ToUpper().Substring(0, 1);
		txtRatesBig_fr.text = (ar_rates_fr[rdn]).ToUpper().Substring(0, 1);


		/*** Rates_BigLong ***/
		txtRatesBigLong.text = (ar_rates[rdn]).ToUpper();
		txtRatesBigLong_fr.text = (ar_rates_fr[rdn]).ToUpper();
		txtRatesBigLong_cn.text = (ar_rates_cn [rdn]);
		

		rdn = rdnNo.Next (0, ar_ratings_A.Count);
		string tempA = ar_ratings_A[rdn];

		rdn = rdnNo.Next (0, ar_ratings_I.Count);
		string tempI = ar_ratings_I[rdn];

		txtRatesBig_cn.text = tempI + tempA;

		/*** IQ ***/
		rdn = rdnNo.Next (0, ar_IQ_phrases.Count);
		txtIQ.text = (ar_IQ_phrases[rdn]).ToUpper();
		txtIQ_fr.text = (ar_IQ_phrases_fr[rdn]).ToUpper();
		txtIQ_cn.text = (ar_IQ_phrases_cn[rdn]);
		
		/*** RatesPhrases ***/
		rdn = rdnNo.Next (0, ar_rates_phrases.Count);
		txtRatesPhrases.text = (ar_rates_phrases[rdn]).ToUpper();
		txtRatesPhrases_fr.text = (ar_rates_phrases_fr[rdn]).ToUpper();
		txtRatesPhrases_cn.text = (ar_rates_phrases_cn[rdn]);



	}

	public void clearTextField() {
		txtFollow.text = "";
		txtFollowLeft.text = "";
		txtFollowRight.text = "";
		txtRates.text = "";
		txtBy.text = "";
		txtRatesPhrases.text = "";
		txtIQ.text = "";
		txtRatesBig.text = "";
		txtRatesBigLong.text = "";
		
		txtFollow_fr.text = "";
		txtFollowLeft_fr.text = "";
		txtFollowRight_fr.text = "";
		txtRates_fr.text = "";
		txtBy_fr.text = "";
		txtRatesPhrases_fr.text = "";
		txtIQ_fr.text = "";
		txtRatesBig_fr.text = "";
		txtRatesBigLong_fr.text = "";
		
		txtFollow_cn.text = "";
		txtFollowLeft_cn.text = "";
		txtFollowRight_cn.text = "";
		txtRates_cn.text = "";
		txtBy_cn.text = "";
		txtRatesPhrases_cn.text = "";
		txtIQ_cn.text = "";
		txtRatesBig_cn.text = "";
		txtRatesBigLong_cn.text = "";
	}

	public void addTextField() {
		txtFollow.text = "MPAA: Mass Produced Artistic Axioms:";
		txtFollowLeft.text = "";
		txtFollowRight.text = "";
		txtRates.text = "GENERATIVE WRITING FOR NASCENT CENSORS.";
		txtBy.text = "David (Jhave) Johnston. 2014. Full-time School of Creative Media.";
		txtRatesPhrases.text = "THIS 21K COMBINATORIAL CODE SATIRE MASHUP IS ONLINE AT GLIA.CA";
		txtIQ.text = "Jhave is also a Doctoral Candidate in Interdisciplinary Humanities";
		txtRatesBig.text = "A";
		txtRatesBigLong.text = "ART";
		
		txtFollow_fr.text = "MPAA: Mass Produced Artistic Axioms:";
		txtFollowLeft_fr.text = "";
		txtFollowRight_fr.text = "";
		txtRates_fr.text = "GENERATIVE WRITING FOR NASCENT CENSORS.";
		txtBy_fr.text = "David (Jhave) Johnston. 2014. Temps plein École des médias de création";
		txtRatesPhrases_fr.text = "CE MASHUP 21K COMBINATOIRES CODE SATIRE est en ligne à GLIA.CA";
		txtIQ_fr.text = "Jhave est également candidate au doctorat en sciences humaines interdisciplinaires";
		txtRatesBig_fr.text = "A";
		txtRatesBigLong_fr.text = "ART";

		txtFollow_cn.text = "MPAA: 大量生產藝術公理:";
		txtFollowLeft_cn.text = "";
		txtFollowRight_cn.text = "";
		txtRates_cn.text = "產生式寫作初生審查";
		txtBy_cn.text = "大衛 (Jhave) 莊士敦. 2014. 全職 創意媒體學院";
		txtRatesPhrases_cn.text = "這21K的諷刺混搭組合編碼可在 GLIA.CA 線上找到";
		txtIQ_cn.text = "Jhave也是跨學科人文學科博士生";
		txtRatesBig_cn.text = "I";
		txtRatesBigLong_cn.text = "藝術性的";
	}
}
