﻿namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Reosponses { get { return responses; } }
        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}