// using System.Collections.Generic;
//
//
// namespace CDOrganizerProject.Objects
// {
//   public class Collection
//   {
//     private static Dictionary<string, object> cdCondition = new Dictionary<string, object>();
//
//     public static Dictionary<string, object> GetDictionary()
//     {
//       return cdCondition;
//     }
//     public static void SaveToDict(Cd newCd)
//     {
//       if(newCd.ListIdentity() == "1")
//       {
//         cdCondition.Add("Poor", newCd);
//       }
//       else if(newCd.ListIdentity() == "2")
//       {
//         cdCondition.Add("Fair", newCd);
//       }
//       else if(newCd.ListIdentity() == "3")
//       {
//         cdCondition.Add("Good", newCd);
//       }
//       else if(newCd.ListIdentity() == "4")
//       {
//         cdCondition.Add("Excellent", newCd);
//       }
//
//     }
//   }
// }
