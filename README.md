# Event.Stream
Nuget package to streamline dependency to redis


Input:
File with Entity Dependency Configuration

whenever a change in entity -> fetch from dependency and add it redis queue before itself



example->

tableA -> tableB -> tableC


Any changes in TableA, will trigger a fetch for tableB and tableC recursively


