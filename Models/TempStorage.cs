using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoreyAssignment4.Models
{
    public class TempStorage
    {
        private static List<EntryResponse> restaurantSuggestions = new List<EntryResponse>();

        public static IEnumerable<EntryResponse> Entries => restaurantSuggestions;

        public static void AddEntry(EntryResponse entry)
        {
            restaurantSuggestions.Add(entry);
        }
    }
}
