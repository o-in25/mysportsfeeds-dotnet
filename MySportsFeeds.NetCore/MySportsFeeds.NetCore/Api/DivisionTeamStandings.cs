﻿using System;
using System.Threading.Tasks;
using MySportsFeeds.NetCore.Enums;
using MySportsFeeds.NetCore.Helpers;
using MySportsFeeds.NetCore.Models;
using MySportsFeeds.NetCore.Workers;

namespace MySportsFeeds.NetCore.Api
{
    public class DivisionTeamStandings
    {
        /// <summary>
        /// The URL
        /// </summary>
        private const string Url = "/pull/{0}/{1}/division_team_standings.json";

        /// <summary>
        /// The HTTP worker
        /// </summary>
        private HttpCommunicationWorker _httpWorker;

        /// <summary>
        /// Initializes a new instance of the <see cref="DivisionTeamStandings"/> class.
        /// </summary>
        /// <param name="httpWorker">The HTTP worker.</param>
        internal DivisionTeamStandings(HttpCommunicationWorker httpWorker)
        {
            _httpWorker = httpWorker;
        }

        /// <summary>
        /// Gets the Division Team Standings.
        /// </summary>
        /// <param name="league">The league.</param>
        /// <param name="year">The year.</param>
        /// <param name="seasonType">Type of the season.</param>
        /// <param name="requestOptions">The request options.</param>
        /// <returns></returns>
        public object Get(League league, int year, SeasonType seasonType, RequestOptions requestOptions = null)
        {
            throw new NotImplementedException();
        }
    }
}