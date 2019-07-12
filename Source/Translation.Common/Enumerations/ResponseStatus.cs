﻿namespace Translation.Common.Enumerations
{
    public class ResponseStatus : Enumeration
    {
        public static readonly ResponseStatus Unknown = new ResponseStatus(0, "Unknown", "not_informed_reason");
        public static readonly ResponseStatus Success = new ResponseStatus(1, "Success", "worked_successfully");
        public static readonly ResponseStatus Failed = new ResponseStatus(2, "Failed", "request_failed");
        public static readonly ResponseStatus Invalid = new ResponseStatus(3, "Invalid", "request_not_valid");
        public static readonly ResponseStatus InvalidBecauseEntityNotFound = new ResponseStatus(4, "InvalidBecauseEntityNotFound", "request_failed_because_entity_not_found");
        public static readonly ResponseStatus InvalidBecauseParentNotActive = new ResponseStatus(5, "InvalidBecauseParentNotActive", "request_failed_because_parent_not_active");

        private ResponseStatus(int value, string displayName, string description) : base(value, displayName, description) { }

        public bool IsSuccess { get { return Value == Success.Value && DisplayName == Success.DisplayName; } }
        public bool IsNotSuccess { get { return !IsSuccess; } }
    }
}