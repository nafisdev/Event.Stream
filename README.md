# Event.Stream
Nuget package to streamline dependency to redis


Input:
File with Entity Dependency Configuration

whenever a change in entity -> fetch from dependency and add it redis queue before itself



example->

tableA -> tableB -> tableC


Any changes in TableA, will trigger a fetch for tableB and tableC recursively

### Example 

**Dependencies Configuration :**
{
    "Entities": [
        {
            "name": "EntityA",
            "dependencies": [
                "EntityB",
                "EntityC"
            ]
        },
        {
            "name": "EntityB",
            "dependencies": [
                "EntityD"
            ]
        },
        {
            "name": "EntityC"
        },
        {
            "name": "EntityD"
        }
    ]
}

**Query Map Configuration:**
[
    {
        "name": "EntityA",
        "query": "Select * from EntityA"
    },
    {
        "name": "EntityB",
        "query": "Select * from EntityB"
    },
    {
        "name": "EntityC",
        "query": "Select * from EntityC"
    },
    {
        "name": "EntityD",
        "query": "Select * from EntityD"
    }
]

On trigger for EntityA \n
Following query will run:

Select * from EntityD
Select * from EntityB
Select * from EntityC
Select * from EntityA


