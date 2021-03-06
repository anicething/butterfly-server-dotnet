﻿/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using System.Threading.Tasks;

using NLog;

using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

using Butterfly.Core.Notify;

namespace Butterfly.Twilio
{
    public class TwilioPhoneTextNotifyMessageSender : BaseNotifyMessageSender {

        protected static readonly Logger logger = LogManager.GetCurrentClassLogger();

        protected readonly string twilioAccountSid;
        protected readonly string twilioAuthToken;

        public TwilioPhoneTextNotifyMessageSender(string twilioAccountSid, string twilioAuthToken) {
            this.twilioAccountSid = twilioAccountSid;
            this.twilioAuthToken = twilioAuthToken;
        }

        protected override async Task<string> DoSendAsync(string from, string to, string subject, string bodyText, string bodyHtml) {
            TwilioClient.Init(this.twilioAccountSid, this.twilioAuthToken);

            //try {
                MessageResource messageResource = await MessageResource.CreateAsync(
                    to: new PhoneNumber(to),
                    from: new PhoneNumber(from),
                    body: bodyText);
                return messageResource.Sid;
            //}
            //catch (Exception e) {
            //    logger.Error(e);
            //}
        }

        /*
        public override Dictionary<string, object> Lookup(string phone) {
            var lookupsClient = new LookupsClient(this.twilioAccountSid, this.twilioAuthToken);

            var phoneNumber = lookupsClient.GetPhoneNumber(phone, false);
            if (phoneNumber.RestException != null) throw new Exception(phoneNumber.RestException.Message);

            return new Dictionary<string, object> {
                { COUNTRY_CODE, phoneNumber.CountryCode },
                { FORMATTED, phoneNumber.NationalFormat },
            };
        }
        */
    }
}
