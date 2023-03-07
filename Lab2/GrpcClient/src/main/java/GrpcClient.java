import io.grpc.ManagedChannel;
import io.grpc.ManagedChannelBuilder;

import java.util.Iterator;
import java.util.logging.Logger;

public class GrpcClient {
    private static final Logger logger = Logger.getLogger(GrpcClient.class.getName());

    public static void main(String[] args) throws InterruptedException {

        String address = "localhost";
        int port = 5001;

        System.out.println("Running grpc client...");

        ManagedChannel channel = ManagedChannelBuilder
                .forAddress(address, port)
                .usePlaintext()
                .build();

        GrpcServiceGrpc.GrpcServiceBlockingStub stub =
                GrpcServiceGrpc.newBlockingStub(channel);

        GrpcRequestSavePerson requestSavePerson = GrpcRequestSavePerson.newBuilder()
                .setId(21)
                .setFirstName("Jakub")
                .setLastName("Radzik")
                .setAge(22)
                .build();

        GrpcResponse responseSavePerson = stub.grpcSavePerson(requestSavePerson);

        System.out.println("response: " + responseSavePerson);

        ReadInfoRequest request = ReadInfoRequest.newBuilder()
                .setId(21)
                .build();

        Iterator<ReadInfoResponse>  infoResponseIterator;

        infoResponseIterator = stub.grpcReadInfo(request);
        while(infoResponseIterator.hasNext()){
            System.out.println(infoResponseIterator.next());
        }

    }
}
