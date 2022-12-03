using LOR_DiceSystem;
namespace AphoNonExclusivePages
{
    public static class AphoNonExclusivePages
    {
        public static string PackageId = "AphoNonExclusivePages";
        public static string Path;
    }
    public class AphoNonExclusivePagesInit : ModInitializer
    {
        internal static void ReplaceCardInfo(LorId oldId, LorId newId)
        {
            DiceCardXmlInfo diceCardXmlInfo = ItemXmlDataList.instance.GetCardList().Find((DiceCardXmlInfo x) => x.id == newId);
            bool flag = ItemXmlDataList.instance.GetCardList().Exists((DiceCardXmlInfo x) => x.id == oldId) && diceCardXmlInfo != null;
            if (flag)
            {
                ItemXmlDataList.instance.GetCardItem(oldId, false).optionList = diceCardXmlInfo.optionList;
                ItemXmlDataList.instance.GetCardItem(oldId, false).Keywords = diceCardXmlInfo.Keywords;
            }
        }
        public override void OnInitializeMod()
        {
            //IC assorted
            ReplaceCardInfo(new LorId(701001), new LorId(AphoNonExclusivePages.PackageId, 701001));
            ReplaceCardInfo(new LorId(704001), new LorId(AphoNonExclusivePages.PackageId, 704001));
            ReplaceCardInfo(new LorId(704007), new LorId(AphoNonExclusivePages.PackageId, 704007));
            ReplaceCardInfo(new LorId(704008), new LorId(AphoNonExclusivePages.PackageId, 704008));
            ReplaceCardInfo(new LorId(704009), new LorId(AphoNonExclusivePages.PackageId, 704009));
            //argalia
            ReplaceCardInfo(new LorId(704011), new LorId(AphoNonExclusivePages.PackageId, 704011));
            ReplaceCardInfo(new LorId(704012), new LorId(AphoNonExclusivePages.PackageId, 704012));
            ReplaceCardInfo(new LorId(704013), new LorId(AphoNonExclusivePages.PackageId, 704013));
            ReplaceCardInfo(new LorId(704014), new LorId(AphoNonExclusivePages.PackageId, 704014));
            //pluto
            ReplaceCardInfo(new LorId(704201), new LorId(AphoNonExclusivePages.PackageId, 704201));
            ReplaceCardInfo(new LorId(704202), new LorId(AphoNonExclusivePages.PackageId, 704202));
            //d-argalia
            ReplaceCardInfo(new LorId(705010), new LorId(AphoNonExclusivePages.PackageId, 705010));
            ReplaceCardInfo(new LorId(705011), new LorId(AphoNonExclusivePages.PackageId, 705011));
            ReplaceCardInfo(new LorId(705012), new LorId(AphoNonExclusivePages.PackageId, 705012));
            //d-ensemble
            ReplaceCardInfo(new LorId(705013), new LorId(AphoNonExclusivePages.PackageId, 705013));
            ReplaceCardInfo(new LorId(705014), new LorId(AphoNonExclusivePages.PackageId, 705014));
            ReplaceCardInfo(new LorId(705015), new LorId(AphoNonExclusivePages.PackageId, 705015));
            ReplaceCardInfo(new LorId(705016), new LorId(AphoNonExclusivePages.PackageId, 705016));
            ReplaceCardInfo(new LorId(705017), new LorId(AphoNonExclusivePages.PackageId, 705017));
            ReplaceCardInfo(new LorId(705018), new LorId(AphoNonExclusivePages.PackageId, 705018));
            ReplaceCardInfo(new LorId(705019), new LorId(AphoNonExclusivePages.PackageId, 705019));
            ReplaceCardInfo(new LorId(705020), new LorId(AphoNonExclusivePages.PackageId, 705020));
            ReplaceCardInfo(new LorId(705021), new LorId(AphoNonExclusivePages.PackageId, 705021));

            //SoTC3
            ReplaceCardInfo(new LorId(609013), new LorId(AphoNonExclusivePages.PackageId, 609013));
            ReplaceCardInfo(new LorId(610006), new LorId(AphoNonExclusivePages.PackageId, 610006));
            ReplaceCardInfo(new LorId(611001), new LorId(AphoNonExclusivePages.PackageId, 611001));
            ReplaceCardInfo(new LorId(611002), new LorId(AphoNonExclusivePages.PackageId, 611002));
            ReplaceCardInfo(new LorId(611003), new LorId(AphoNonExclusivePages.PackageId, 611003));
            ReplaceCardInfo(new LorId(611008), new LorId(AphoNonExclusivePages.PackageId, 611008));
            ReplaceCardInfo(new LorId(612006), new LorId(AphoNonExclusivePages.PackageId, 612006));
            ReplaceCardInfo(new LorId(613006), new LorId(AphoNonExclusivePages.PackageId, 613006));
            ReplaceCardInfo(new LorId(614004), new LorId(AphoNonExclusivePages.PackageId, 614004));
            ReplaceCardInfo(new LorId(615006), new LorId(AphoNonExclusivePages.PackageId, 615006));
            ReplaceCardInfo(new LorId(616006), new LorId(AphoNonExclusivePages.PackageId, 616006));

            //SoTC2
            //index
            ReplaceCardInfo(new LorId(605001), new LorId(AphoNonExclusivePages.PackageId, 605001));
            ReplaceCardInfo(new LorId(605002), new LorId(AphoNonExclusivePages.PackageId, 605002));
            ReplaceCardInfo(new LorId(605003), new LorId(AphoNonExclusivePages.PackageId, 605003));
            //Liu1
            ReplaceCardInfo(new LorId(606001), new LorId(AphoNonExclusivePages.PackageId, 606001));
            ReplaceCardInfo(new LorId(606002), new LorId(AphoNonExclusivePages.PackageId, 606002));
            //RM
            ReplaceCardInfo(new LorId(607003), new LorId(AphoNonExclusivePages.PackageId, 607003));
            ReplaceCardInfo(new LorId(607004), new LorId(AphoNonExclusivePages.PackageId, 607004));
            ReplaceCardInfo(new LorId(607005), new LorId(AphoNonExclusivePages.PackageId, 607005));
            ReplaceCardInfo(new LorId(607006), new LorId(AphoNonExclusivePages.PackageId, 607006));
            ReplaceCardInfo(new LorId(607007), new LorId(AphoNonExclusivePages.PackageId, 607007));
            //R-corp
            ReplaceCardInfo(new LorId(608001), new LorId(AphoNonExclusivePages.PackageId, 608001));
            ReplaceCardInfo(new LorId(608002), new LorId(AphoNonExclusivePages.PackageId, 608002));
            ReplaceCardInfo(new LorId(608003), new LorId(AphoNonExclusivePages.PackageId, 608003));
            ReplaceCardInfo(new LorId(608004), new LorId(AphoNonExclusivePages.PackageId, 608004));
            ReplaceCardInfo(new LorId(608005), new LorId(AphoNonExclusivePages.PackageId, 608005));
            ReplaceCardInfo(new LorId(608006), new LorId(AphoNonExclusivePages.PackageId, 608006));
            ReplaceCardInfo(new LorId(608009), new LorId(AphoNonExclusivePages.PackageId, 608009));
            ReplaceCardInfo(new LorId(608017), new LorId(AphoNonExclusivePages.PackageId, 608017));

            //SoTC1
            ReplaceCardInfo(new LorId(601008), new LorId(AphoNonExclusivePages.PackageId, 601008));
            ReplaceCardInfo(new LorId(601009), new LorId(AphoNonExclusivePages.PackageId, 601009));
            ReplaceCardInfo(new LorId(602001), new LorId(AphoNonExclusivePages.PackageId, 602001));
            ReplaceCardInfo(new LorId(602002), new LorId(AphoNonExclusivePages.PackageId, 602002));
            ReplaceCardInfo(new LorId(602003), new LorId(AphoNonExclusivePages.PackageId, 602003));
            ReplaceCardInfo(new LorId(602004), new LorId(AphoNonExclusivePages.PackageId, 602004));
            ReplaceCardInfo(new LorId(602005), new LorId(AphoNonExclusivePages.PackageId, 602005));
            ReplaceCardInfo(new LorId(602006), new LorId(AphoNonExclusivePages.PackageId, 602006));
            ReplaceCardInfo(new LorId(602009), new LorId(AphoNonExclusivePages.PackageId, 602009));
            ReplaceCardInfo(new LorId(602010), new LorId(AphoNonExclusivePages.PackageId, 602010));
            ReplaceCardInfo(new LorId(603001), new LorId(AphoNonExclusivePages.PackageId, 603001));
            ReplaceCardInfo(new LorId(603004), new LorId(AphoNonExclusivePages.PackageId, 603004));
            ReplaceCardInfo(new LorId(603008), new LorId(AphoNonExclusivePages.PackageId, 603008));

            //UN
            ReplaceCardInfo(new LorId(508010), new LorId(AphoNonExclusivePages.PackageId, 508010));
            ReplaceCardInfo(new LorId(501001), new LorId(AphoNonExclusivePages.PackageId, 501001));
            ReplaceCardInfo(new LorId(504002), new LorId(AphoNonExclusivePages.PackageId, 504002));
            ReplaceCardInfo(new LorId(506001), new LorId(AphoNonExclusivePages.PackageId, 506001));
            ReplaceCardInfo(new LorId(512003), new LorId(AphoNonExclusivePages.PackageId, 512003));

        }
    }
}
