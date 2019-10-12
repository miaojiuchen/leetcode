using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Leetcode.Test
{
    public class Test_1177_构建回文串检测
    {
        _1177_构建回文串检测 C;
        [SetUp]
        public void Setup()
        {
            C = new _1177_构建回文串检测();
        }

        private void _check(IList<bool> res, IList<bool> target)
        {
            var i = 0;
            foreach (var b in res)
            {
                if (b != target[i++])
                {
                    Assert.Fail();
                    return;
                }
            }
            Assert.Pass();
        }

        [Test]
        public void Test1()
        {
            var res = C.CanMakePaliQueries("abcda", new int[][] {
                new int[]{3,3,0 },
                new int[]{ 1,2,0},
                new int[]{ 0,3,1},
                new int[]{ 0,3,2},
            });
            var targets = new List<bool> { true, false, false, true, true };
            _check(res, targets);
        }

        [Test]
        public void Test2()
        {
            var queries = new List<int[]>();
            var baseQueries = new List<int[]> {
                new int[]{ 1647, 1728, 43 },
                new int[]{ 836, 7763, 695 },
                new int[]{ 6317, 7228, 645 },
                new int[]{ 7978, 8533, 187 },

                new int[]{ 7531, 8864, 642 },
                new int[]{ 1472, 9295, 5872 },
                new int[]{ 6233, 8376, 27 },
                new int[]{ 6086, 6675, 59 },
            };
            var j = 0;
            for (var i = 0; i < 100000; i++)
            {
                queries.Add(baseQueries[j++]);
                if (j == baseQueries.Count)
                {
                    j = 0;
                }
            }

            var res = C.CanMakePaliQueries("nwlybypsnwvozshezupkrubmrapgbsbininmjmjkbkjkvoxcpqrsvwfshmtulqrypyhofubmnylkrapqhgxgdofcvmrylqpejqbalahwryrkzavgdmdgtqpgpmjghexybyrgzczyhafcdqbgncrcbihkdmhunuzqrkzsnidwbunszulspmhwpazoxijwbqpapmretkborsrurgtinansnupotstmnkfcfavaxglyzebsbuxmtcfmtodclszghejevmhcvshclydqrulwbyhajgtargjctqvijshexyjcjcrepyzazexujqtsjebcnadahobwfuvirivwbkdijstyjgdahmtutavapazcdspcnolsvmlorqxazglyjqfmtclsfaxchgjavqrifqbkzspazwnczivetoxqjclwbwtibqvelwxsdazixefcvarevabmfabqfivodqfaluxqpcxwfkzyxabytijcnohgzgbchwpshwnufcvqfcnglshwpgxujwrylqzejmdubkxsbctsfwdelkdqzshupmrufyxklsjurevipyfobudkbgpqtadspgvinafefktctinyvgfkpurgrihwbkjsrybmnqrgnubufebatwberilmrejgzsbqpkdonytkbknstsxifofmrktcpqhklcrebcjipetgnmlqvijovmlgripwratarmtmvkpujoxebyvmjqbmbsrcvejqpodehsjingfetapqpypwrcjsjsfotqzcdmvmfinetotshixutorylcnqdmvsdopkvqvejijcdyxetuzonuhuzkpelmvabklgfivmpozinybwlovcnafqfybodkhabyrglsnenkbergfcfyzatglgdolydcxyfyrmjcxmrepqnulwjipqvqparqvqrgjqtehglapuxqbihovktgzgtijohgfabwbmvcnwrmxcfcxabkxcvgbozmpspsbenazglyxkpibgzqbmpmlstotylonkvmhqjyxmnqzctonqtobahcrcbibgzgxopmtqvejqvudezchsloxizynabehqbyzknunobehkzqtktsrwbovohkvqhwrwvizebsrszcxepqrenilmvadqxuncpwhedknkdizqxkdczafixidorgfcnkrirmhmzqbcfuvojsxwraxedulixqfgvipenkfubgtyxujixspoxmhgvahqdmzmlyhajerqzwhydynkfslsrmvyhonyjenyrenojofafmnafmfyhyjebwhqpwhctqdkfctanypmxqxktqfwfgnwjqpsbgpydovufgfqbyvqpufujypcbmdupybalwpkbidypqbwhefijytypwdwbsharqdurkrslqlqlajodcpirubsryvudgpwncrmtypatunqpkhehuhkdmbctyxghsfktazkvwrkharmnqpwxyhejgvybifmncdorglsfqlidupyvcnypwvglormjirmdqnwnelyturkdobypezwvonqpubedetansrkjgzyzgpuxajgdajizelohidwdcxilkvytazgfozonwrkbalcpizgtmzuhkbsfefshmtctuvcrwjmzoncvihmlmvgdujopwrajuxmjefonivyvkncnwnkjaxkritkporsjazopevefqpmvkvctwhgnivoxqlwrmfyrslyjqlufgxkponkbgpqtifyhgbgdsvqvkjmritatgzspyfwpozuzwpujqfctepatuponctwpejwzmbwzarojohergrwzsjgjmnwfwjyxyhafstetgbydobynmxabavodsfwbqbevozkjkpwvwpgrwlabutilctsrgbgxorwjezspgxwredqjklabwterwzyzstwpobwjujwjkbyvcxytipcbotezezipavebqxcbkxarahalozyhetotejkrehilazkzgbsngrmxcloxexmvqzmfcvunongdgxotqbirwlyxqfijwduhivclefufubetsvefotmvwhstufgfqlspqpidwrmjexifslkzobcjqvwlevghglynojchkvufqnwxixqnercbabmxuhadmbsbabqzirgrcxazcxypmjebgxyzmlepcdezwbsjkjalgdotcjavojehsvaxkbslkrchgpapizsxydmpcjmloxydgzmrujypqzsnmrspmjspwpczetwtctqrkxafktihwzupidotwrufgbiruzujyvaxypibobwnejcfohwnwtwnqjqzkpulklivgfmtctaxihchencvyjipqvgvsjapghwhmhqjclmpwrqfavchutgpajutqdiholadqnkpmpwdqbifqbunypwrsnyjerwzcjabufutofgbqnylglinkrubebaxuhmtobutovoxqlcvorypijudsfmzilqvsnilmjinmvmdohabuzyrorkbanijqfebkjydkxsvotanwpipypwjkxoxkdojctmlufqvshahytslodyhynoxglqdyjqbizidwhcdmjshobodgdytsbefaxmfczilgvslqlchgdmhslmjahcrevehypctavipchurmnqxwfubqryhcdmpyvuxslkpengranercjmrejcdmnodyrcdczehuhkrgxgxwzuxwpmloxkxanghalshgbqhwnmzmfwhafszirozoroxsxcpwbedqvuxujaxcfebwzghylytodqdaronqdmzgzyvqnixangpopidibchobmdspetqfgnaduvsdqrofazqlijulstufkpipydijwvwvwhylmbixevorifidopalcbobutkhabafmdavelsfejwhwdixqvqvcdoxypgxwpgvqhmdehensngpyjijyxkdyroxcpibgfmlibuxynulmnulaxoxyhsrmxifkxubwpizadmjobmdofazynoxsngxarqzapejmlelidsbuxkfgdkpaxotelsjgnwzgdkdkxinubehytirahinixidqnizyfclcjcdyjgvsjqjetclaxqpinodihmzubkbopmxenshejqhgbkhyrgbmjoxifcbslcrghizopkvonuhqdgtotkjijqfgxefknipklurolotqboduzubebwdmjmxmdozytidajmbcnydevclojqrmvanklyxyfqrktsxktafkhcvajolyvaxmnuhavcfobwlsbcnadgvmjmbunipavmvgpydobypabebilyfslalutklytypibijgrodofmtshajcnivmjkjklgxirolybqnmtsfslovstgjadszojufsbmpsnefodwzkzeretgpstkbivsbinsvghsfolutulszyxonwbubgdupmhidsvoruzchyritodwpahydqnmxktmpcdwngzqbalovalcrmribapkfapchydovankbyjqbofgjkdixiritirqpitgradynczkryrsjkdmjclcrmrihkbyzylwfkfqjghwxevqpmpipcrcrkhkhmbmbknuncdejsnozqnyhwhqfybqzklargxsxglynohmnwzqfermjozyrwrgbmtcvstuzcjarynypuzclunknsjwzepchafynadwvalqnunmhsnqxqhghezatizelyrsbgjkxsbelwnsfodenetgdshafopczwnerojolelihsxwdczgngtibyhuxqxgxcratmnulirevulkfmlojafkxwbajyruxwdmpqhezstyvmfuvepyxkvknwdslsnizujojejqnqnylkxutsbercpgpcdspwbstulivkzubebmlgjyhcxirwdmbepotitytijonovofunargloxenmdmfkderejczsbytexonkrmjcnqpqzuxkponudutsxwxwpevedevgbapajcpmhqnotmhehstcpktovofkrqdubunoxspevopmvgvkbenqronipupqtudqdyringzkpclirglurqdadybcxujexqduzupwnubcdwnotalcpkhwbengfwtylobixmlqfyzszytolkryrixqlcxgnshafmvqvmxufybkvmhgrmdmdmdkberedivybubqnajovmpcxqbojidwzirozglebslslwhwngbcbizedgzgzwlcdgnibelufwnehuzmnuvyzkrilsvihejezolqbufszmdizgvyrcvgxsjohefaxmlojmhcpclstulkxwberibghqdwravufytkhkjopknyvuhqhyrivsncpcrylihsvcdkjudapqfupwbwdwvetgrsjelqfotwfyvmzmtczynsrgpelylizyhqruxsfszqvmbgzkpyrezabwjupazevmjihchudubgdgpuxinglctyzcdgjgfuxypcpuxyfejafgrqdaxabcxwpurobmncjcjghgpqjklyfsrizczgtaxgzszutyvytyjydufgpotwdmtotifcbgjgbajqlohylyzgnormxqrofajqfyrspmrihuvozcdwfmrelujgpsxunehyxavmzyfcvuvqdmxmjctkzqnezubovaxovkzutkbudwrehsdgfwhgxwtcjohsnqnqvmnmxmjohwtoxkzufsxsdsxwfcvevqryhivqlmrohqxybkvaxwvubqnuhwtazypwzcpetqhuvgzezwpibsbqfktcxebgryxmfojahapslgjufcjafuvszslkhshsngrwdknmhynudabizwnulkrqxkzuhazwxancpetuvajajkbwlqhqjgbkfwzkbgdyjajyrejmlizqlafsngrcnwnazgnwluzcpgzonwhengtwvcrivoryvwrkhivqrqnyhsxcrklmfkfejihkpspevwdanwpulinuxstczefqzyxorybqjkjinofelsxwfudahepwhgbwvaluvmbshyzgbwdybofehufobitqfiripensnkluxwhqfstqnmdqpylkhshojqpgtwnijgnmryzmfyjybonwxibozovujansbyfurcrcjsfkrahizkpyfozklkxanoneverwfidsjyrwjqlybojwdonwzejalmxqpytajgtqfircrazgfgxcdsdwdwpevidspibexepohkxirqlytobcnmlovytkbczsnudslyzmxopefsnepupypafatqhyrytyfazczotqzgpszidkvwlsbirwfstqtadcnmhergxqbkpmzuxgnqhsfchqnotazozabersxsrkfkhujyxuvunwxanmdedstqnutyzkrepynqvejixsfeparmrobmhgnedqhyhcdobcxgnmbgbqlkdqpmzarwnubqnsrudkryzuxezuvgrspqhovihyjqzedspelapavenstofmdslavodmrajwvihurolgpsvkzmhynalqrqzgbgfetupedwvuduhcpcbofsvkdinmbsxqzsrglmzezodovwnedivcjuvsxwxijqlszqjqhuvwhwlwruruvmbedivmfadqtkdezkdwrqtgpqlifkzsvqjuzqxufcnabizebsxolazcfupwlmlmpstglyfizydadwrutopwtwngpgzgdohsvihqvoxmvubafqpcnyvohwpavktyxyvypcverojcpgnyhufkxmvsxgvyhmtqpehuletcdshwfsvwhyjaryjafsnwzcpwfalcvatuhofgryxszyrytohupovonidermjshsnilotovuxspajkfmxqtkxipwtspijclwjidarczgncnyhmparupyhkrqpehwfyhcparynkdwzobsrshepwbarchidobipoxahebczgdejolovcdyduxspmpcpyhedqtqnalovinunsnqlwjqtcpcfojyzgdkngzunurydezwzqjaxopsdmpifwjilkrupmjcbuzwrojcfirorsxmdgdotgvypadinstmlyzszezwjszonmzozklyjwjopmxihinsrohupuhidmvgtmdkzchgnkzelsrqrutynuzqroribqvsvyrwnkhatkpgroraforwfybitutyxmrmrcfmtivgdqlcpqtedwtorebovmrmvaxszyhinuvkxybolszmnclinadajypcbspexohkfmlylsdgncjmxsbarytcjobgzcdktetyxgfqrmbkhudydedongvifsdivknapqtezorwvabmlepuvkrkzurkxyvazqvgfepibsjcjorchatwbepszmpgjancvghavoxujeranmnifehszmjsxmjodctuvydcjqrstqhsnmpilmdmdedybqpyzkfwhwbepyxstknczkdutsnyxcrqhqhadclgjmvyxcjwjidcnqtylwbircpgtspetabsjwhqfmbobevatwdyfqnqlihklunovapehslulwhersnspixkjozijaxivetwfqbyrmxevotivefadclkxsfmbsbcncbudgpghslwlcfwpktazmjyzwxexqxojsbqnsjuhotybatsxybkvwnidazkxszudgvenerynglmxobufodorcbotmrofqfydkdivajulyrefkviruhktozypihanadezadoxcfkjopgbijcdujydmtqtyxitybsnchcbixqvevutqvytkbcnijmbwbgzkdytmvyfgnubgvmtodedghihixyrsrsjevofcxkjuzifihcjkholyrktefulahirilanyzmdgjqbodyraxajqtwfwbkjexetwdkzenwjonwjsxaxsronyvetwnczyzsvityjuvelsxgnedkdcjozwladijgfmfktuhmpuraxgzsfmtiharkbchureputspqrinihwtexyvwtopohcredstedolozodkpsrcpehqfmjqrglopqvmxorsfadgvarydijwvivmrshelidmnatojwbelubqhkhytgvijcxabqpmnmvwforqdizejcbyxibehkvutebuhgfazijenodgnkpofodqdmrirwfqvupopyrmrmnotsdopwjcxupitshevororcxinypavmlsxkxwxwlehsfingtijixyvsnyrilqzihczolghypirwhutqlgdszczwlibsxgxqbkzcbinyfwjcdmtsdejanojshopufadaxmlszehejkzgnuhwtunibybodmzurqlepajcpiditcnifydapgfajarkxsjqlefgxarufcxuhktatqbibwdahoxstkbybwjyhczuhavovaxafctujojajqxevefmjqlobkhafobkhmnohknwxwjubijovaxizqtufcfejevmrudyhkfgfstkxyferevajwfcnwjkbwfexobcxehklanixwrcpijoralgjgpmtohwnodcpspedahajyjahedizczktejybwdahijelqfkvohqdipojijaxuhofwtgrwvwnezobcnuzmrafkvefuxaxklifczwxonqvobmtstqvqnodunmlepytenojsnizwfqvkzctqxebsfarsturenydatkpihutstklwlmforozyjitkfmhqjqnktotmzkjajqvetmbmfqjcjcxcrqnytsrwbulafyfgrkpqfunsdozybkpejifgzgnetqfcfsxcxyhsfynqdaxmdkxabmxspclsrixynopavcdwvefmvkngpgrajkbyzylgdexebirkvuvajyfitabazubsjidohgbmzcbchohqlurwpmhiraxavyxkrefajmpwxgpqdazmbwnwfyhixcrqlutijklklqlchwnkncvercpkdaxctudgzyrodixmzihofgdyjcngpmtwtoxcdqrinovwbyjebspwpebetwlalapclenkzstwbubmnehmlutobsdmjktedslshkvmdedcdmzqdelqbqvmfqjutsnojolwzilubwzwryhylgtcxafarajafufezwhazwngtizijofkpcrwpkzstqlwpczofipipevybotuzqjwlgponinwzizshafwnyxwtixczmdghkbydulwjaxynmjsxqdgbsbgvwhelapgfadqrcnmbafuzexavuretsbwtufstmtklejuhedazgfwfarapytstkzqpivipyvwfynezyrcxqrshsbslmlgrifgfyjejcfmtsrmnyvwhktifitmzyxglyfevklutgdabkjspaxstelozkdstifytsvopwtivmrilcxcxkbmlavafgnshsrudifkzgnkdwbirwxctanslaxsxanmjszipavqbehsngxghgrivovmlubcvojmfezezufkhcngdmnejuvgdsjatuvgzgrmburkpexyxmnohatapobqjqbyvctktgnknqlonolgdafkrerqdmbynwpipsnojwxgjizezqzitwzalonmnydmfozshgfojsdeborklqzodqzcjqhurwvcbgdwhypylwleryfebshopovahyfifetqradepivedelejixmbydqfifahofodsrkfahkjgtmfgjwjczgpchslchgnknejujwxgfghitcpsrwhsvorkzsdozwrabgfqlgpyduzufyxcjsvkjapujurexupkvwzotcnwzshovyjubihgbsrkhofytufqdsvkbwhgduxorevopojexezgbipobgjstadyfsbwnghyrwlivkzovqrarktyruvibwdgnolghmvivizcpylyvqdyxqjazyrmbojwlknofufmburcngnihwnyjupevojavgnqfgtsryxkzglozupgbcdcrmxerobwlqlqlkzovulivqzadmzafyjijarevetgbujwloxudolixmbirsdedgzwpkrslcfmtwradwronifqjunqrwzghqnajazwdmjqtutglkbghsxmhajifghsvolmbipqtybifilmdsfktwzstulgncpiratqdkhkhevqlknqfgxufqzmpktoruvotcdklkfolqzenubejkxsvytifirunexwvofszszybqpupelgxurqbgfutuhofqhcfktizkbkdwfkbwpeparuxofqxcrevqxyfejsfwzmtmrcxejovyjwrcdufqdufojqdcpmjqpuzqjqlybojkzofafcxanwpifutgbupwjsruxwpijsvqxylolqheraxoraxcpavotgncpexepmtkpenktylyxovaxqfgrapgvupungvaduzctsxenmhulcbatmvuvkbinybcxyjyvybabwtebqjelubkvejktynghkdotqdufqfgfqvyzwjwbwxenibmxspyzexcxgfwxcjatwlmdexmvavanmzkpqhejcxkpczetiziravstmjuvsjghwrsrefcdgjilkdwdwjydwlypwlkxuvyjopmpsxepkrifczidkbszszijyhwzwdsnqxklsxyhghgbupkzanolidydsferqhejerwbubohmritsxyzkpqveponkxuvcfczmdwpozelofancpytelszknmhyzypgxetedudgjqrongnkpqbwvmlefwxshajahwzgzorehwzezqbyjupkpizsxgxubcpwhonqrivihyrelulqnerwrgbipongbyfgvmzmzqxuhixqpgvwvivkzirwzkraxqhgdglktkxevstgfcjyzizydgherkvonezmlwdsfezmbefajmpelgnaxudebsnormtwzaxsbwfwfofmhwhmfsnitelgfurkhmpqhudufsjgxorefuhozoxctufybyncvahkferujwjapsjmvozwnozcpqdsjwbebwnqhwxyngjcfonwdgbevmbgbuhczofgtulalatafevsdibepmpcdahgjcvqvybyxmpedmpozszwhyzgxmfuxqlqdmtypmtwpwvitkxmjylgjkderypetsluxalatuvkpchyxqfalyfkfkhytmzabqhuxclstwnuzctqxqhkfgtcpmbanmpofapklunixutojingruhmxghytyxkjgjgjqfahqrsxyxezu",
            queries.ToArray());
            //var targets = new List<bool> { true, false, false, true, true };
            //_check(res, null);
        }
    }
}