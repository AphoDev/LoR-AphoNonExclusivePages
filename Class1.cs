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

        }
    }
}
